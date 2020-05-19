import { Component } from '@angular/core';
import { CharacterDataService } from '../character-data';
import { Character } from '../Interfaces/Character';
import { ActivatedRoute, Router } from '@angular/router'; //what do you do?


@Component({
    selector: 'app-add-player',
    templateUrl: './add-player.component.html',
    styleUrls: ['./add-player.component.scss']
})
/** add-player component*/
export class AddPlayerComponent {
  charName: string;

  /** add-player ctor */
  constructor(private characterData: CharacterDataService, private router: Router) {

  }

  submitPlayer() {
    if (this.charName == '') {
      return;
    }

    let newPlayer: Character = {
      CharName: this.charName,
      HP: 20,
      AP: 3,
      Progress: 0,
      Player: true
    }

    this.characterData.addPlayer(newPlayer).subscribe();
    this.router.navigate(['']);
  }

}
