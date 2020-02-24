import { Component, OnInit, ViewChild } from '@angular/core';
import { carrierAddComponent } from '../carrier/carrier-add.component';
import { CarrierDataService } from '../carrier/DataService'
import { carrier } from 'src/app/carrier/carrier'
import { Router } from '@angular/router';
import { carrierupdateComponent } from '../carrier/carrierupdate.component';

@Component({
  selector: 'carrier.component',
  templateUrl: './carrier.component.html'
})
export class carrierComponent implements OnInit {


  carlist: carrier[];
  dataavailbale: Boolean = false;
  tempemp: carrier

  constructor(private dataservce: CarrierDataService, private route: Router) {
  }

  ngOnInit() {
    this.LoadData();
  }

  LoadData() {

    this.dataservce.getcarrier().subscribe((tempdate) => {
      this.carlist = tempdate;
      console.log(this.carlist);
      if (this.carlist.length > 0) {
        this.dataavailbale = true;
      }
      else {
        this.dataavailbale = false;
      }


    }
    )
      , err => {
        console.log(err);
      }
  }
  //deleteconfirmation(id: string) {

  //  if (confirm("Are you sure you want to delete this ?")) {
  //    this.tempemp = new carrier();
  //    this.tempemp.Id = id;
  //    this.dataservce.DeleteEmployee(this.tempemp).subscribe(res => {
  //      alert("Deleted successfully !!!");
  //      this.LoadData();
  //    })
  //  }
  //}
  @ViewChild('carrieradd') addcomponent: carrierAddComponent
  @ViewChild('regForm') editcomponent: carrierupdateComponent



  loadAddnew() {
    console.log("test");
    this.addcomponent.objCar.bussiness_Address = ""
    this.addcomponent.objCar.bussiness_Name = ""
    this.addcomponent.objCar.bussiness_Phone_Number = ""
    this.addcomponent.objCar.Id = ""
    this.addcomponent.objCar.myProperty = ""
  }

  loadnewForm(id: string, email: string, firstname: string, lastname: string, gender: string) {
    console.log(gender);
    this.editcomponent.objemp.bussiness_Address = email
    this.editcomponent.objemp.bussiness_Name = firstname
    this.editcomponent.objemp.bussiness_Phone_Number = lastname
    this.editcomponent.objemp.Id = id
    this.editcomponent.objemp.myProperty = gender
  }

  RefreshData() {
    this.LoadData();
  }

}
