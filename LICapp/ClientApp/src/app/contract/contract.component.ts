import { Component, OnInit, ViewChild, Input, EventEmitter, Output, ElementRef } from '@angular/core';
import { Router } from '@angular/router';
import { NgForm } from '@angular/forms';
import { CarrierDataService } from '../carrier/DataService'
import { carrier } from 'src/app/carrier/carrier'

@Component({
  selector: 'app-contract',
  templateUrl: './contract.component.html'  
})
export class contractComponent implements OnInit {
    ngOnInit(): void {
        
    }

  constructor(private dataservice: CarrierDataService, private route: Router) {

  }

  onOptionsSelected(value: string) {
    console.log("the selected value is " + value);
  }

}
