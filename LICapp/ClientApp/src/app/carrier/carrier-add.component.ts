import { Component, OnInit,Input, ViewChild, ElementRef, EventEmitter, Output } from '@angular/core';
import { NgForm } from '@angular/forms';
import { CarrierDataService } from '../carrier/DataService'
import { carrier } from 'src/app/carrier/carrier'
import { Router } from '@angular/router';
@Component({
  selector: 'app-carrier-add',
  templateUrl: './carrier-add.component.html'
})
export class carrierAddComponent implements OnInit {
  
  @Input()  cleardata: boolean = false;
  @Output() nameEvent = new EventEmitter<string>();
  objtempemp: carrier;
  @Input() objCar: carrier = new carrier();
  @ViewChild('closeBtn') cb: ElementRef;
  constructor(private dataservice: CarrierDataService,private route:Router) {
 
 }
 
  ngOnInit() {
  // this.ResetValues();
  }

  ResetValues(){  
   
   
  }  
 
     Register(regForm:NgForm){  
   
       this.objtempemp = new carrier();
       this.objtempemp.bussiness_Address = regForm.value.bussiness_Address;
       this.objtempemp.bussiness_Name = regForm.value.bussiness_Name;
       this.objtempemp.myProperty = regForm.value.myProperty;
       this.objtempemp.bussiness_Phone_Number = regForm.value.bussiness_Phone_Number;
    
       this.dataservice.Addcarrier(this.objtempemp).subscribe(res=>{
    alert("Employee Added successfully");
    this.TakeHome();
}
  )
  
  
  } 
  TakeHome(){
    this.nameEvent.emit("ccc");
    this.cb.nativeElement.click();
    this.route.navigateByUrl('');
  }

}
