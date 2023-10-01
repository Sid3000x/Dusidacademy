import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './components/layout/navbar/navbar.component';
import { CadastroAlunosComponent } from './components/pages/cadastro-alunos/cadastro-alunos.component';
import { ConsultaAlunosComponent } from './components/pages/consulta-alunos/consulta-alunos.component';
import { EdicaoAlunosComponent } from './components/pages/edicao-alunos/edicao-alunos.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    CadastroAlunosComponent,
    ConsultaAlunosComponent,
    EdicaoAlunosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
