import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IBooks } from '../IBooks';

@Injectable({
  providedIn: 'root'
})
export class BooksService {
  baseUrl:string="/assets/data/books.json"
  constructor(private http:HttpClient) { }

  getAllBooks():Observable<IBooks[]>{
    return this.http.get<IBooks[]>(this.baseUrl);
  }
}
