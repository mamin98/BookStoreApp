import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class LocalStorageService {
  constructor() {}

  public getData(key: string) {
    return localStorage.getItem(key);
  }

  public saveData(key: string, value: string) {
    localStorage.setItem(key, value);
  }

  public removeData(key: string) {
    localStorage.removeItem(key);
  }

  public clearData() {
    localStorage.clear();
  }
}
