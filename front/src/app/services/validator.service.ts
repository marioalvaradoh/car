import { Injectable } from '@angular/core';
import { AbstractControl, FormGroup } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class ValidatorService {

  constructor() { }

  invalidField(
    formGroup: FormGroup
    , formControlName: string
    , validation: string): boolean {
    let control: AbstractControl | null = formGroup?.get(formControlName);
    return control?.errors?.[validation] && (control?.touched || control?.dirty);
  }

  markAndValidateForm(formGroup: FormGroup): boolean {
    formGroup?.markAllAsTouched();
    return formGroup?.valid;
  }
}
