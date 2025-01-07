import { CdkStepperModule } from '@angular/cdk/stepper';
import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Output } from '@angular/core';
import { FileUploadComponent } from "../../../../../../_common/file-upload/file-upload.component";
import {
  FormBuilder,
  FormGroup,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { LockerDocument } from '../../../../../../_model/Owner/business-documents';

@Component({
  selector: 'app-step-three',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule, CdkStepperModule, FileUploadComponent],
  templateUrl: './step-three.component.html',
  styleUrl: './step-three.component.css',
})
export class StepThreeComponent {
  @Output() stepThreeSubmitted = new EventEmitter<LockerDocument>();

  public stepThreeForm!: FormGroup;
  state: string = '';
  LockerImages: File[] = [];
  documentProofFile: File[] = [];

  proofOfIdentityOptions = [
    { id: 1, value: 'Aadhaar Card (India-specific)', label: "Aadhaar Card (India-specific)" },
    { id: 2, value: 'Passport', label: "Passport" },
    { id: 3, value: "Driver's License", label: "Driver's License" },
    { id: 4, value: 'National ID Card', label: "National ID Card" },
  ];

  constructor(private fb: FormBuilder) {
    this.initializeForm();
  }

  private initializeForm(): void {
    this.stepThreeForm = this.fb.group({
      documentProofType: ['', Validators.required],
      documentProofFile: [null, Validators.required],
      lockerImages: [null, Validators.required],
    });
  }

  uploadDocumentProof(files: File[]): void {
    this.documentProofFile = files;
    if (this.documentProofFile.length > 0) {
      this.stepThreeForm.controls['documentProofFile'].setValue(files[0]);
      this.stepThreeForm.controls['documentProofFile'].setErrors(null);
    } else {
      this.stepThreeForm.controls['documentProofFile'].setErrors({ required: true });
    }
  }

  handleLockerImages(files: File[]): void {
    this.LockerImages = files;
    if (this.LockerImages.length > 0) {
      this.stepThreeForm.controls['lockerImages'].setValue(files);
      this.stepThreeForm.controls['lockerImages'].setErrors(null);
    } else {
      this.stepThreeForm.controls['lockerImages'].setErrors({ required: true });
    }
  }

  stepThreeSubmit() {
    if (this.stepThreeForm.valid) {
      this.state = 'done';
      const formData = this.stepThreeForm.value;
      this.stepThreeSubmitted.emit(formData);
    }
  }
}
