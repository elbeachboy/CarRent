import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';  
import { Observable } from 'rxjs';  
import { map } from 'rxjs/operators';  

@Injectable({
  providedIn: 'root'
})
export class CustomerManagementService {
  url1 = 'https://localhost:44313/api/Customer/CustomerByName';
  url2 = 'https://localhost:44313/api/Customer/CustomerById';
  constructor(private http: HttpClient) { }

  searchCustomersByName(name: string): Observable<any> {  
    return this.http.get(`${this.url1}/${encodeURI(name)}`).pipe(      
      map(results => results)  
    );  
  }

  searchCustomerById(id: string): Observable<any> {  
    return this.http.get(`${this.url2}/${encodeURI(id)}`).pipe(      
      map(results => results)  
    );  
  }

}
