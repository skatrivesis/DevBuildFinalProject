import { Component } from '@angular/core';

@Component({
    selector: 'app-character',
    templateUrl: './character.component.html',
    styleUrls: ['./character.component.scss']
})
/** character component*/
export class CharacterComponent {

  id: number;
  charName: string;
  hp: number;
  ap: number;
  progress: number;
  player: boolean;

    /** character ctor */
    constructor() {

  }


  AddCharacter() {

  }
}
