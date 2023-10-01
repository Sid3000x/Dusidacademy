import { RouterModule, Routes } from "@angular/router";
import { CadastroAlunosComponent } from "./components/pages/cadastro-alunos/cadastro-alunos.component";
import { ConsultaAlunosComponent } from "./components/pages/consulta-alunos/consulta-alunos.component";
import { EdicaoAlunosComponent } from "./components/pages/edicao-alunos/edicao-alunos.component";
import { NgModule } from "@angular/core";


// mapeamento das rotas do projeto
const routes: Routes = [
{ path: 'pages/cadastro-alunos', component: CadastroAlunosComponent },
{ path: 'pages/consulta-alunos', component: ConsultaAlunosComponent },
{ path: 'pages/edicao-alunos', component: EdicaoAlunosComponent },
{ path: '', pathMatch: 'full', redirectTo:'pages/consulta-alunos' }
];


@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})


export class AppRoutingModule {}

