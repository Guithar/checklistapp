import { Routes } from '@angular/router';
import { ClientListComponent } from './client-list/client-list.component';
import { ChecklistListComponent } from './checklist-list/checklist-list.component';
import { HomeComponent } from './home/home.component';

export const appRoutes: Routes = [
  { path: '', component: HomeComponent},
  { path: 'clients', component: ClientListComponent},
  { path: 'checklists', component: ChecklistListComponent},
  { path: '**', redirectTo: '', pathMatch: 'full'},
];

