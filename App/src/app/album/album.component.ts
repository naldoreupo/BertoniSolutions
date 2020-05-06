import { Component, OnInit } from '@angular/core';
import { AlbumService } from '../album.service';


@Component({
  selector: 'app-album',
  templateUrl: './album.component.html',
  styleUrls: ['./album.component.css']
})
export class AlbumComponent implements OnInit {
  albums;
  constructor(private apiService: AlbumService) { }

  ngOnInit(): void {
    debugger;
    this.apiService.getAll().subscribe((data)=>{
      console.log(data);
      this.albums = data['list'];
    });
  }

}
