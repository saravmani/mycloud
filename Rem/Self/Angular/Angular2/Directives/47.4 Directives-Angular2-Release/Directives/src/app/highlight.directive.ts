import { Directive, HostListener, HostBinding, Input } from '@angular/core';
// import { ElementRef, Renderer } from '@angular/core';

@Directive({
    selector: '[highlight]'
})
export class HighlightDirective {
    @HostListener('mouseenter') mouseover() {
        this.backgroundColor = this.highlightColor;
    };
    @HostListener('mouseleave') mouseleave() {
        this.backgroundColor = this.defaultColor;
    };
    @HostBinding('style.backgroundColor') get setColor() {
      return this.backgroundColor;
    };
    @Input() defaultColor = 'white';
    @Input('highlight') highlightColor = 'green';

    // constructor(private elementRef: ElementRef, private renderer: Renderer) {}

    private backgroundColor: string;
    constructor() {
        // this.elementRef.nativeElement.style.backgroundColor = 'green';
        // this.renderer.setElementStyle(this.elementRef.nativeElement, 'background-color', 'green');
    }

    ngOnInit() {
        this.backgroundColor = this.defaultColor;
    }
}
