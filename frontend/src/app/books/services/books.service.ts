import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { IBooks } from '../IBooks';
import { ApiPaths } from 'src/app/enums/api-paths';

@Injectable({
  providedIn: 'root'
})
export class BooksService {
  // baseUrl:string="/assets/data/books.json"
  constructor(private http:HttpClient) { }

  // getAllBooks():Observable<IBooks[]>{
  //   return this.http.get<IBooks[]>(this.baseUrl);
  // }

  getAllBooks(){
    return this.http.get(environment.baseApi + ApiPaths.AllBooks)

  }
  getBooksID(id:any){
    return this.http.get(environment.baseApi + ApiPaths.OneBook + id)
  }

  getAllCategories(){
    return this.http.get(environment.baseApi + ApiPaths.Categories)
  }
//=======================================
  getBooksByCategory(id:any){
    return this.http.get(environment.baseApi + ApiPaths.Categories  + id)
  }
}
