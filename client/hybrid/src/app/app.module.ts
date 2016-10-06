import { NgModule } from '@angular/core';
import { IonicApp, IonicModule } from 'ionic-angular';
import {Http} from '@angular/http';

import { MyApp } from './app.component';

import { TranslatePipe, TranslateService, TranslateLoader, TranslateStaticLoader } from 'ng2-translate/ng2-translate';

import { RuleOneRatingComponent } from '../+rule-one'

// Pages
import { DashboardComponent } from '../+dashboard';
import { CompanyListComponent, CompanyDetailComponent, CompanyEditComponent, CompanyService } from '../+companies';



// Components
import { SignInComponent, IdentityPopoverComponent, IdentityService } from '../+identity'
import { UserPortfolioComponent, UserWatchlistComponent } from '../+dashboard';
import {
  RuleOneComponent,
  MeaningStatementComponent,
  ThreeCirclesComponent,
  FiveMoatsComponent,
  BigFiveComponent,
  BigFiveAnnualComponent,
  BigFiveGrowthComponent,
  EmaChartComponent,
  MacdChartComponent,
  StochasticChartComponent,
  MoatComponent,
  MeaningComponent,
  LevelFiveLeadersComponent,
  MarginComponent,
  ThreeToolsComponent
 } from '../+rule-one'


// Services
import { PortfolioService, WatchlistService } from '../+dashboard';
import { ManagementService, MeaningService, MoatService, ThreeToolsService } from '../+rule-one'

@NgModule({
  declarations: [
    MyApp,
    // Pages
    DashboardComponent,
    CompanyListComponent,
    CompanyDetailComponent,
    CompanyEditComponent,
    // Components
    SignInComponent,
    UserPortfolioComponent,
    UserWatchlistComponent,
    RuleOneComponent,
    RuleOneRatingComponent,
    BigFiveAnnualComponent,
    BigFiveGrowthComponent,
    MeaningStatementComponent,
    ThreeCirclesComponent,
    FiveMoatsComponent,
    BigFiveComponent,
    EmaChartComponent,
    MacdChartComponent,
    StochasticChartComponent,
    MoatComponent,
    MeaningComponent,
    LevelFiveLeadersComponent,
    MarginComponent,
    ThreeToolsComponent,
    IdentityPopoverComponent,
    // Pipes
    TranslatePipe
  ],
  imports: [
    IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    SignInComponent,
    DashboardComponent,
    CompanyListComponent,
    CompanyDetailComponent,
    CompanyEditComponent
  ],
  providers: [
    // Services
    IdentityService,
    TranslateService,
    PortfolioService,
    WatchlistService,
    ManagementService,
    MeaningService,
    CompanyService,
    MoatService,
    ThreeToolsService,
    {
      provide: TranslateLoader,
      useFactory: (http: Http) => new TranslateStaticLoader(http, 'assets/i18n', '.json'),
      deps: [Http]
    }
  ]
})
export class AppModule {}