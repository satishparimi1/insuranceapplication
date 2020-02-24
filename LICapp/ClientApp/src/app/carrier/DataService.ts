import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { carrier } from 'src/app/carrier/carrier'
import { Observable } from 'rxjs';
@Injectable()
export class CarrierDataService {
  carriers: Observable<carrier[]>;
  newcarrier: carrier;
  ROOT_URL: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.ROOT_URL = baseUrl;
  }

  getcarrier() {
    return this.http.get<carrier[]>(this.ROOT_URL + 'api/carrier');
  }
  Addcarrier(car: carrier) {
    const headers = new HttpHeaders().set('content-type', 'application/json');
    var body = {
      bussiness_Name: car.bussiness_Name, bussiness_Address: car.bussiness_Address, bussiness_Phone_Number: car.bussiness_Phone_Number, myProperty: car.myProperty
    }
    console.log(this.ROOT_URL);

    return this.http.post<carrier>(this.ROOT_URL + '/carrier', body, { headers });

  }

  ///
  Editcarrier(car: carrier) {
    console.log(car);
    const params = new HttpParams().set('ID', car.Id);
    const headers = new HttpHeaders().set('content-type', 'application/json');
    var body = {
      bussiness_Name: car.bussiness_Name, bussiness_Address: car.bussiness_Address, bussiness_Phone_Number: car.bussiness_Phone_Number, myProperty: car.myProperty
    }
    return this.http.put<carrier>(this.ROOT_URL + 'carrier/' + car.Id, body, { headers, params })

  }
  //Deletecarrier(car: carrier) {
  //  const params = new HttpParams().set('ID', car.id);
  //  const headers = new HttpHeaders().set('content-type', 'application/json');
  //  var body = {
  //    Fname: car.firstname, Lname: car.lastname, Email: car.email, ID: car.id
  //  }
  //  return this.http.delete<carrier>(ROOT_URL + '/carriers/' + car.id)

  //}


}
