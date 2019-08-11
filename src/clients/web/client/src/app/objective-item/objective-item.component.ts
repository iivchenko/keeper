import { Component } from "@angular/core"

@Component({
    selector: 'objective-item',
    templateUrl: './objective-item.component.html'
})

export class ObjectiveItem{
    public name:string = 'This is a test objective'
    public description:string = 'This description relates to the todo item that is not even tested by me so we just'

}