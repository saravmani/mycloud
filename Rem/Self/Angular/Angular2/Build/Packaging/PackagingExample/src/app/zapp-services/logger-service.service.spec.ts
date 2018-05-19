import { TestBed, inject } from '@angular/core/testing';

import { LoggerServiceService } from './logger-service.service';

describe('LoggerServiceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [LoggerServiceService]
    });
  });

  it('should be created', inject([LoggerServiceService], (service: LoggerServiceService) => {
    expect(service).toBeTruthy();
  }));
});
