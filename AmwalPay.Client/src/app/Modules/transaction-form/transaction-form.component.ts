import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { TransactionService } from '../transaction.service';

@Component({
  selector: 'app-transaction-form',
  templateUrl: './transaction-form.component.html',
  styleUrls: ['./transaction-form.component.css']
})
export class TransactionFormComponent implements OnInit {

  constructor(private transactionService:TransactionService) { }

  TransactionForm = new FormGroup({
      processingCode : new FormControl(''),
      systemTraceNr : new FormControl(''),
      functionCode : new FormControl(''),
      cardNo : new FormControl(''),
      cardHolder : new FormControl(''),
      amountTrxn : new FormControl(''),
      currencyC : new FormControl(''),
  });


response:any
  ngOnInit(): void {






    this.TransactionForm = new FormGroup({


      processingCode : new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
        Validators.maxLength(20),
      ]),
      systemTraceNr : new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
        Validators.maxLength(20),
      ]),
      functionCode : new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
        Validators.maxLength(20),
      ]),
      cardNo : new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
        Validators.maxLength(16),
      ]),
      cardHolder : new FormControl('', [
        Validators.required,
        Validators.maxLength(20),

      ]),
      amountTrxn : new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
        Validators.maxLength(6),


      ]),
      currencyC : new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
        // Validators.minLength(8),
      ])    
    });
  }
  onSubmitTransactionForm() {
    console.log("TransactionForm",this.TransactionForm.value);
    this.transactionService.addTransaction(this.TransactionForm.value).subscribe((res)=>{
        console.log(res);
        this.response=JSON.stringify(res)
        
    })
  }

    
get processingCode() { return this.TransactionForm.get('processingCode'); }
get systemTraceNr() { return this.TransactionForm.get('systemTraceNr'); }
get functionCode() { return this.TransactionForm.get('functionCode'); }
get cardNo() { return this.TransactionForm.get('cardNo'); }
get cardHolder() { return this.TransactionForm.get('cardHolder'); }
get amountTrxn() { return this.TransactionForm.get('amountTrxn'); }
get currencyC() { return this.TransactionForm.get('currencyC'); }

}
