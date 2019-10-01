import { Routes } from '@angular/router';
import { ClientListComponent } from './client-list/client-list.component';
import { ChecklistListComponent } from './checklist-list/checklist-list.component';
import { HomeComponent } from './home/home.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
  { path: '', component: HomeComponent},
  { path: 'clients', component: ClientListComponent, canActivate: [AuthGuard]},
  { path: 'checklists', component: ChecklistListComponent},
  { path: '**', redirectTo: '', pathMatch: 'full'},
];

