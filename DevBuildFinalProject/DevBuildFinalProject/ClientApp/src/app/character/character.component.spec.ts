/// <reference path="../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { CharacterComponent } from './character.component';

let component: CharacterComponent;
let fixture: ComponentFixture<CharacterComponent>;

describe('character component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ CharacterComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(CharacterComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});