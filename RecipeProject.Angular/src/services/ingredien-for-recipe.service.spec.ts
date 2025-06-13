import { TestBed } from '@angular/core/testing';

import { IngredienForRecipeService } from './ingredien-for-recipe.service';

describe('IngredienForRecipeService', () => {
  let service: IngredienForRecipeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(IngredienForRecipeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
