import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, map } from 'rxjs';
import { ApiPaths } from 'src/app/enums/api-paths';
import { Book } from 'src/app/model/Book';
import { Category } from 'src/app/model/Category';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class AdminService {

  deletePath: string= environment.baseApi+ApiPaths.OneBook;
  constructor(private http: HttpClient) {}

  

  getAllBooks() {
    return this.http.get<Book[]>(environment.baseApi + ApiPaths.AllBooks);
  }
  
  getBooksID(id: number) {
    return this.http.get(environment.baseApi + ApiPaths.OneBook + id);
  }

  getAllCategories() {
    return this.http.get<Category[]>(environment.baseApi + ApiPaths.Categories);
  }

  getBooksByCategory(id: number): Observable<Book[]> {
    return this.http
      .get<Book[]>(environment.baseApi + ApiPaths.Categories + id)
      .pipe(
        // todo: response type
        map((response: any) => {
          return response.books;
        })
      );
  }

  // Delete Book by id
  DeleteBook(id:any){
    return this.http.delete(this.deletePath+ id);
  }
}
