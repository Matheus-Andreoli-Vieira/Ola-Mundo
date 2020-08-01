<?php
class aluno{
    public $nome;
    private $idade;
    public $periodo;

public function _construct($name,$age,$per){
    $this->setNome($name);
    $this->setIdade($age);
    $this->setPeriodo($per);
}
}
?>