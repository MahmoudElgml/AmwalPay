import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TransactionService {

  constructor(private http: HttpClient) { }
   
  addTransactionURL="https://localhost:7104/api/Transaction/AddTransaction"

  addTransaction(data:any) {
    // now returns an Observable of Config
    return this.http.post<any>(this.addTransactionURL,data);
  }
}
