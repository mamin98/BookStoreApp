/// <reference types="@angular/localize" />

import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { defineComponents, IgcRatingComponent } from 'igniteui-webcomponents';
import { AppModule } from './app/app.module';

// setup ratings lib
defineComponents(IgcRatingComponent);

platformBrowserDynamic().bootstrapModule(AppModule)
  .catch(err => console.error(err));
