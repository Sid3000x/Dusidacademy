import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CadstroFornecedoresComponent } from './cadastro-fornecedores.component';

describe('CadstroFornecedoresComponent', () => {
  let component: CadstroFornecedoresComponent;
  let fixture: ComponentFixture<CadstroFornecedoresComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CadstroFornecedoresComponent]
    });
    fixture = TestBed.createComponent(CadstroFornecedoresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
