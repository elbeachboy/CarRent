import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { CustomerManagementPage } from './customer-management.page';

describe('CustomerManagementPage', () => {
  let component: CustomerManagementPage;
  let fixture: ComponentFixture<CustomerManagementPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CustomerManagementPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(CustomerManagementPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
