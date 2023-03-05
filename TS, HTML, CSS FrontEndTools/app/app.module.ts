import { ModuleWithProviders, NgModule} from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatButtonModule } from '@angular/material/button';
import { MatSliderModule } from '@angular/material/slider';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatInputModule } from '@angular/material/input';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatIconModule } from '@angular/material/icon';
import { MatFormFieldModule } from '@angular/material/form-field';
import { ReactiveFormsModule } from '@angular/forms';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { AngularFireModule } from '@angular/fire/compat';




import { HttpClientModule } from '@angular/common/http';
import { MatExpansionModule } from '@angular/material/expansion';



//toolbar importit
import { MatToolbarModule } from '@angular/material/toolbar';
import { RouterModule, Routes } from '@angular/router';
import { MatMenuModule } from '@angular/material/menu';


import { PageNotFoundComponent } from './page-not-found/page-not-found.component'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CalculatorComponent } from './calculator/calculator.component';
import { FeedbackComponent } from './feedback/feedback.component';
import { HelloWorldComponent } from './hello-world/hello-world.component';
import { TemplateDrivenFormComponent } from './template-driven-form/template-driven-form.component';
import { ReactiveFormComponent } from './reactive-form/reactive-form.component';
import { CinemaComponent } from './cinema/cinema.component';
import { HomeComponent } from './home/home.component';
import { PipeNamePipe } from './pipes/pipe-name..pipe';
import { LoginComponent } from './login/login.component';
import { AdminComponent } from './admin/admin.component';
import { environment } from 'src/environments/environment';
import { AuthGuard } from './shared/auth.guard';




const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'calculator', component: CalculatorComponent },
  { path: 'feedback', component: FeedbackComponent },
  { path: 'hello-world', component: HelloWorldComponent },
  { path: 'appComponent', component: AppComponent },
  { path: 'templateDrivenForm', component: TemplateDrivenFormComponent },
  { path: 'reactive-form', component: ReactiveFormComponent },
  { path: 'cinema', component: CinemaComponent },
  { path: 'home', component: HomeComponent },
  { path: 'login', component: LoginComponent },
  { path: 'admin', component: AdminComponent },
  { path: 'admin/main', component: AdminComponent, canActivate: [AuthGuard] },


  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    CalculatorComponent,
    FeedbackComponent,
    HelloWorldComponent,
    TemplateDrivenFormComponent,
    ReactiveFormComponent,
    CinemaComponent,
    HomeComponent,
    PipeNamePipe,
    LoginComponent,
    AdminComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatSliderModule,
    MatGridListModule,
    MatInputModule,
    FormsModule,
    MatToolbarModule,
    MatMenuModule,
    MatIconModule,
    MatFormFieldModule,
    ReactiveFormsModule,
    MatCheckboxModule,
    HttpClientModule,
    MatExpansionModule,
    AngularFireModule.initializeApp( environment.firebase, 'angular-auth-firebase') as ModuleWithProviders<AngularFireModule>,
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: true }
    )
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
