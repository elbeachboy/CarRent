import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';  
import { Observable } from 'rxjs';  
import { map } from 'rxjs/operators';  

@Injectable({
  providedIn: 'root'
})
export class CustomerManagementService {
  url = 'https://localhost:44313/api/Customer/CustomerByName';
  constructor(private http: HttpClient) { }

  searchCustomer(name: string): Observable<any> {  
    return this.http.get(`${this.url}/${encodeURI(name)}`).pipe(      
      map(results => results)  
    );  
  }
}
