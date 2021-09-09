import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { AccountService } from './_services/account.service';

const routes: Routes = [
  //{path:'movies', component: MoviesListComponent},
  {path:'user', component: NavComponent},
  {path:'**', redirectTo: 'account/login'},
  {path: '' , redirectTo:'/', pathMatch:'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
