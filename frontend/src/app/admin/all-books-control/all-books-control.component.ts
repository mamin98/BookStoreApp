import { Component } from '@angular/core';
import { Router } from '@angular/router';

import { Book } from 'src/app/model/Book';
import { Category } from 'src/app/model/Category';
import { AdminService } from '../services/admin.service';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-all-books-control',
  templateUrl: './all-books-control.component.html',
  styleUrls: ['./all-books-control.component.scss'],
})
export class AllBooksControlComponent {
  books: Book[] = [];
  p: number = 1;
  title = 'appBootstrap';
  closeResult: any;
  selectedItemsCount: number = 0;

  bookForm!: FormGroup //= new FormGroup({});

  constructor(
    private service: AdminService,
    private router: Router,
    private modalService: NgbModal,
    private formBuilder: FormBuilder,
  ) {}

  Categories: Category[] = [];
  addButton: boolean = false;
  cartBooks: any[] = [];
  loading: boolean = false; // this for spinner

  booksByCategory!: Book[];
  // categories: any = this.getCategories();

  ngOnInit(): void {
    this.getAllBooks();
    // From
    this.bookForm = this.formBuilder.group({
      title: new FormControl(''),
      isbn: new FormControl(''),
      price: new FormControl(''),
      image: new FormControl(''),
      publisherId: new FormControl(''),
      // 'authorId ': new FormControl(''),
      // 'typeId ': new FormControl('')
    })
    // From
  }


  getAllBooks() {
    this.loading = true; //  spinner open
    this.service.getAllBooks().subscribe((data: Book[]) => {
      this.books = data;
      this.loading = false;
    });
  }

//=======================modal===============================
  open(content: any) {
    this.modalService
      .open(content, { ariaLabelledBy: 'modal-basic-title' })
      .result.then(
        (result) => {
          this.closeResult = `Closed with: ${result}`;
        },
        (reason) => {
          this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
        }
      );
  }

  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return `with: ${reason}`;
    }
  }
 //=======================modal===============================
  // Delete Book
  Delete(id:any){
    this.service.DeleteBook(id).subscribe((res:any)=>{

      if(confirm("Opps! Book Will be delete")){this.getAllBooks()}
      else{
        alert("Well, Book not deleted")
      }

    })
  }


  // Add new book
  createBook(){
    console.log(this.bookForm.value);
    this.service.addBook(this.bookForm.value).subscribe(data => {
      console.log("book Created")
    });
  }


}
