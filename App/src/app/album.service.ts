import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AlbumService {

  constructor(private httpClient: HttpClient) { }
  public getAll(){
    return this.httpClient.get(`https://localhost:44393/api/album`);
  }
}
