import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { RequestModel } from '../models/request/RequestModel';
import { ResponseModel } from '../models/response/ResponseModel';

@Injectable({
  providedIn: 'root'
})
export class TestService {

  constructor(private httpClient: HttpClient) { }

  Create(requestModel: RequestModel): Observable<ResponseModel> {
    return this.httpClient.post<ResponseModel>(`${environment.Apis.endpointCreateTest}WeatherForecast`, requestModel);
  }
}
