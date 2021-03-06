import { Component, OnInit } from '@angular/core';
import { AlbumService } from './album.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent  implements OnInit  {
  albums;
  constructor(private apiService: AlbumService) { }

  title = 'App';  ngOnInit(): void {
    debugger;
    this.apiService.getAll().subscribe((data)=>{
      console.log(data);
      this.albums = data['list'];
    });
  }
}
