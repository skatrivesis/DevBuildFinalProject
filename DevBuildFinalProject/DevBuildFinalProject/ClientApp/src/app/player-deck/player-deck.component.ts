import { Component, Input } from '@angular/core';
import { CardDataService } from '../card-data';
import { Card } from '../Interfaces/Card';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-player-deck',
  templateUrl: './player-deck.component.html',
  styleUrls: ['./player-deck.component.scss']
})
/** player-deck component*/
export class PlayerDeckComponent {

  userId: number;
  cards: Card[];

  /** player-deck ctor */
  constructor(private cardData: CardDataService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {

    this.route.params.subscribe(params => {
      this.userId = +params['userId'];
    });

    this.cardData.getAllCardsOwnedById(this.userId).subscribe(
      (data: Card[]) => {
        this.cards = data;
        console.log(this.cards);
      },
      error => console.error(error)
    );
  }
}
