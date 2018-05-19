import { Input, Component, OnInit, AfterViewInit, ViewEncapsulation, ViewChild, 
  ComponentRef, ViewContainerRef, ComponentFactory, ComponentFactoryResolver, Compiler, 
  ChangeDetectorRef } from '@angular/core';
import { ReportEventManagerService } from '../../RptEngProcessor/report-event-manager.service';

@Component({
  selector: 'rpt-section-loader-component',
  templateUrl: './rpt-section-loader-component.component.html',
  styles: []
})
export class RptSectionLoaderComponentComponent implements OnInit {
  @ViewChild("ComponentHolder", { read: ViewContainerRef }) ComponentHolder;
  cmpRef: any;
  @Input() componentToBeLoaded: any;
  @Input() reportDataObject: any;
  @Input() canAddSectionGap: boolean;
  

  @Input() isOnlyFullViewComponent: boolean = true;
  isfullviewMode: boolean = false;

  constructor(private objReportEventManagerService: ReportEventManagerService, private componentFactoryResolver: ComponentFactoryResolver, private compiler: Compiler,
    private cdRef: ChangeDetectorRef) { }
  ngOnInit() {
    this.objReportEventManagerService.onViewModeChange.subscribe(viewMode => {
      this.isfullviewMode = viewMode;
    });

  }

  ngAfterViewInit() {
    if (this.cmpRef) {
      this.cmpRef.destroy();
    }

    let factory = this.componentFactoryResolver.resolveComponentFactory(this.componentToBeLoaded);
    this.cmpRef = this.ComponentHolder.createComponent(factory);
    this.cmpRef.instance.dataCollection = this.reportDataObject;
    this.cdRef.detectChanges();

    if (this.isOnlyFullViewComponent) {
      this.objReportEventManagerService.onViewModeChange.subscribe(viewMode => {
        this.isfullviewMode = viewMode;
      });
    }
  }



}
