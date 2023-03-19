import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { IBooks } from '../IBooks';

@Injectable({
  providedIn: 'root'
})
export class BooksService {
  baseUrl:string="/assets/data/books.json"
  constructor(private http:HttpClient) { }

  // getAllBooks():Observable<IBooks[]>{
  //   return this.http.get<IBooks[]>(this.baseUrl);
  // }

  getAllBooks(){
    return this.http.get(environment.baseApi +'Book/books')

  }
  getBooksID(id:any){
    return this.http.get(environment.baseApi +'Book/' + id)
  }

  GetAllCategories(){
    return this.http.get(environment.baseApi +'Types')
  }

  getBooksByCategory(id:string){
    return this.http.get(environment.baseApi +'Types/' + id)
  }
}
