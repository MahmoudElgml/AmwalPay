import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-transaction-form',
  templateUrl: './transaction-form.component.html',
  styleUrls: ['./transaction-form.component.css']
})
export class TransactionFormComponent implements OnInit {

  constructor() { }


  TransactionForm = new FormGroup({
    inputProcessingCode: new FormControl(''),
    inputSystemTraceNr: new FormControl(''),
    inputCardHolder: new FormControl(''),
    inputCardNo: new FormControl(''),
    inputFunctionCode4: new FormControl(''),
    inputAmountTrxn: new FormControl(''),
    inputCurrencyCode4: new FormControl(''),
  });
  ngOnInit(): void {
  }
  onSubmitTransactionForm() {
    console.log("TransactionForm",this.TransactionForm.value);
    
  }
}
