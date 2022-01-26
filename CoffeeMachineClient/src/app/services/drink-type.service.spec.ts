import { TestBed } from '@angular/core/testing';

import { DrinkTypeService } from './drink-type.service';

describe('DrinkTypeService', () => {
  let service: DrinkTypeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DrinkTypeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
