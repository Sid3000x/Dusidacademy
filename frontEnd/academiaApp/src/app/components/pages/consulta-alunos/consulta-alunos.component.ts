import { Component, OnInit } from '@angular/core';
import { Aluno } from 'src/app/shared/model/aluno-model';

@Component({
  selector: 'app-consulta-alunos',
  templateUrl: './consulta-alunos.component.html',
  styleUrls: ['./consulta-alunos.component.css']
})
export class ConsultaAlunosComponent implements OnInit {
  constructor(){}

alunos: Aluno [] = []
quantidadeDeAlunos: number = 0

ngOnInit(): void {
  this.alunos = [
  {
    nome: "Sidney Junior",
    idade: 30,
    observacoes : "Aluno apto a se exercitar"
  },
  {
    nome: "Rodrigo",
    idade: 27,
    observacoes : "Aluno apto a se exercitar"
  },
  {
    nome: "Debora",
    idade: 28,
    observacoes : "Aluno apto a se exercitar"
  },
  {
    nome: "Matheus",
    idade: 25,
    observacoes : "Aluno apto a se exercitar"
  },
  {
    nome: "Luana",
    idade: 19,
    observacoes : "Aluno apto a se exercitar"
  },


]
this.quantidadeDeAlunos = this.alunos.length;
}




}

