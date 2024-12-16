import { Component } from '@angular/core';
import { CdkStepperModule } from '@angular/cdk/stepper';
import { NgStepperModule } from 'angular-ng-stepper';
import { StepOneComponent } from '../stepperform/step-one/step-one.component';
import { StepTwoComponent } from '../stepperform/step-two/step-two.component';
import { StepThreeComponent } from '../stepperform/step-three/step-three.component';
import { RoomOwner } from '../../../../../_model/RoomOwner/room-owner';
import { Room } from '../../../../../_model/RoomOwner/room';
import { StowzyDocuments } from '../../../../../_model/RoomOwner/business-documents';
import { RoomOwnerService } from '../../../../../_services/room-owner.service';
import { RoomOwnerRegistration } from '../../../../../_model/RoomOwner/room-details';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-room-owner-signup',
  standalone: true,
  imports: [
    CdkStepperModule,
    NgStepperModule,
    StepOneComponent,
    StepTwoComponent,
    StepThreeComponent
  ],
  templateUrl: './room-owner-signup.component.html',
  styleUrl: './room-owner-signup.component.css',
})
export class RoomOwnerSignupComponent {

  private roomOwner!: RoomOwner;
  private room!: Room;
  private stowzyDocuments!: StowzyDocuments;

  constructor(private http: HttpClient, private _roomOwnerService: RoomOwnerService) { }

  onStepOneSubmit(stepOneData: RoomOwner): void {
    this.roomOwner = stepOneData;

  }

  onStepTwoSubmit(stepTwoData: Room): void {
    this.room = stepTwoData;
  }

  onStepThreeSubmit(stepThreeData: StowzyDocuments): void {
    this.stowzyDocuments = stepThreeData;
    this.onFinalSubmit()
  }

  private appendFormData(data: any, prefix: string, formData: FormData): void {
    Object.keys(data).forEach((key) => {
      const value = data[key];
      const formKey = `${prefix}.${key}`;

      if (key === 'profileImage' && value instanceof File) {
        formData.append(formKey, value);
      } else if (key === 'stowzyImages' && Array.isArray(value)) {
        value.forEach((file: File) => formData.append(`${prefix}.stowzyImages`, file));
      } else if (key === 'identityProofDocument' && value instanceof File) {
        formData.append(`${prefix}.identityProofDocument`, value);
      } else {
        formData.append(formKey, value);
      }
    });
  }

  onFinalSubmit(): void {
    const formData = new FormData();
    if (this.roomOwner) {
      this.appendFormData(this.roomOwner, 'roomOwner', formData);
    }

    if (this.room) {
      this.appendFormData(this.room, 'room', formData);
    }

    if (this.stowzyDocuments) {
      this.appendFormData(this.stowzyDocuments, 'stowzyDocuments', formData);
    }

    this._roomOwnerService.roomOwnerRegistration(formData).subscribe({
      next: (response) => {
        console.log('Registration successful:', response);
      },
      error: (error) => {
        console.error('Registration failed:', error);
      },
    });
  }

}