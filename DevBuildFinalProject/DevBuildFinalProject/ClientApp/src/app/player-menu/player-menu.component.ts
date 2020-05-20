import { Component } from '@angular/core';
import { CharacterDataService } from '../character-data';

@Component({
  selector: 'app-player-menu',
  templateUrl: './player-menu.component.html',
  styleUrls: ['./player-menu.component.scss']
})
/** player-menu component*/
export class PlayerMenuComponent {

  userId: number;

  /** player-menu ctor */
  constructor(private characterData: CharacterDataService) { }


  ngOnInit() {
    this.characterData.getCurrentUser().subscribe(
      (data: number) => {
        this.userId = data;
        console.log(this.userId);
      },
      error => console.error(error)
    );
  }
}
