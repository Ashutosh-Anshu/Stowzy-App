import { Component } from '@angular/core';
import { CdkStepperModule } from '@angular/cdk/stepper';
import { NgStepperModule } from 'angular-ng-stepper';
import { Owner } from '../../../../../_model/Owner/owner';
import { LockerDocument } from '../../../../../_model/Owner/business-documents';
import { Locker } from '../../../../../_model/Owner/locker';
import { HttpClient } from '@angular/common/http';
import { OwnerService } from '../../../../../_services/owner.service';
import { StepOneComponent } from '../stepperform/step-one/step-one.component';
import { StepTwoComponent } from '../stepperform/step-two/step-two.component';
import { StepThreeComponent } from '../stepperform/step-three/step-three.component';

@Component({
  selector: 'app-owner',
  standalone: true,
  imports: [CdkStepperModule, NgStepperModule, StepOneComponent, StepTwoComponent, StepThreeComponent],
  templateUrl: './owner.component.html',
  styleUrl: './owner.component.css'
})
export class OwnerComponent {

  private owner!: Owner;
  private locker!: Locker;
  private lockerDocument!: LockerDocument;

  constructor(private http: HttpClient, private _ownerService: OwnerService) { }

  onStepOneSubmit(stepOneData: Owner): void {
    this.owner = stepOneData;

  }

  onStepTwoSubmit(stepTwoData: Locker): void {
    this.locker = stepTwoData;
  }

  onStepThreeSubmit(stepThreeData: LockerDocument): void {
    this.lockerDocument = stepThreeData;
    this.onFinalSubmit()
  }

  private appendFormData(data: any, prefix: string, formData: FormData): void {
    Object.keys(data).forEach((key) => {
      const value = data[key];
      const formKey = `${prefix}.${key}`;

      if (key === 'profileImage' && value instanceof File) {
        formData.append(formKey, value);
      } else if (key === 'lockerImages' && Array.isArray(value)) {
        value.forEach((file: File) => formData.append(`${prefix}.lockerImages`, file));
      } else if (key === 'documentProofFile' && value instanceof File) {
        formData.append(`${prefix}.documentProofFile`, value);
      } else {
        formData.append(formKey, value);
      }
    });
  }

  onFinalSubmit(): void {
    const formData = new FormData();
    if (this.owner) {
      this.appendFormData(this.owner, 'owner', formData);
    }

    if (this.locker) {
      this.appendFormData(this.locker, 'locker', formData);
    }

    if (this.lockerDocument) {
      this.appendFormData(this.lockerDocument, 'lockerDocument', formData);
    }

    this._ownerService.ownerRegistration(formData).subscribe({
      next: (response) => {
        console.log('Registration successful:', response);
      },
      error: (error) => {
        console.error('Registration failed:', error);
      },
    });
  }

}
