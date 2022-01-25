import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { RequestModel } from '../models/request/RequestModel';
import { TestService } from '../services/test.service';
import { ValidatorService } from '../services/validator.service';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {

  constructor(private fb: FormBuilder,
    public validatorService: ValidatorService,
    private testService: TestService) { }

  requestModel: RequestModel = new RequestModel();

  formCreate: FormGroup = this.fb.group({
    make: ['', [Validators.required]],
    year: [''],
    sales: [''],
  });

  success: boolean = false;

  ngOnInit(): void {
  }

  create() {
    this.success = false;
    if (!this.validatorService.markAndValidateForm(this.formCreate)) {
      return;
    }
    Object.assign(this.requestModel, this.formCreate.value);
    this.testService.Create(this.requestModel).subscribe(response =>
    {
      if (response && response.id > 0) {
        this.success = true;
      }
    });
  }

}
