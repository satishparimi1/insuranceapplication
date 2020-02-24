import { Component, OnInit, ViewChild, Input, EventEmitter, Output, ElementRef } from '@angular/core';
import { Router } from '@angular/router';
import { NgForm } from '@angular/forms';
import { CarrierDataService } from '../carrier/DataService'
import { carrier } from 'src/app/carrier/carrier'
@Component({
  selector: 'app-employeeupdate',
  templateUrl: './carrierupdate.component.html'

})
export class carrierupdateComponent implements OnInit {

  constructor(private dataservice: CarrierDataService, private route: Router) {

  }
  @Output() nameEvent = new EventEmitter<string>();
  @ViewChild('closeBtn') cb: ElementRef;
  ngOnInit() {
  }

  @Input() reset: boolean = false;
  @ViewChild('regForm') myForm: NgForm;
  @Input() isReset: boolean = false;
  objtempemp: carrier;
  @Input() objemp: carrier = new carrier();

  EditEmployee(regForm: NgForm) {


    this.dataservice.Editcarrier(this.objemp).subscribe(res => {
      alert("Employee updated successfully");
      this.nameEvent.emit("ccc");
      this.cb.nativeElement.click();

    },
    )}

}
