<!DOCTYPE html>
<html lang='pt-br'>
    <head>
        <meta charset = 'UTF-8'>
        <title>Spa</title>
        <style>
            body{
               background-color: rgba(241, 104, 41, 0.89);
               font: normal 12pt Courier;
            }
            header{
                text-align: center;
                color: white;
            }
            footer{
                color: white;
                border-top: 1px solid black;
                text-align: center;
                padding: 10px;
                margin-top: 10px;
            }
            section{
                background-color: white;
                width: 500px;
                box-shadow: 1px 1px 10px black;
                border-radius: 10px;
                position: relative;
                text-align: left;
                margin: auto;
                padding: 10px;
            }
        </style>
    </head>
    <body>
        <div>
            <header>
                Programa Spa
            </header>
            <section>
                <form method="get">
                    <p>Nome: <input type="text" name="nome"></p>
                    <p>Data de Entrada: <input type="date" name="data"></p>
                    <p>Valor: <input type="number" name="valor"></p>
                    <fieldset>
                        <legend>Planos</legend>
                        <p><input type="radio" name="plan" value="1">Plano Anti-stress – valor + 6%</p>
                        <p><input type="radio" name="plan" value="2">Plano Reeducação – valor + 8%</p>
                        <p><input type="radio" name="plan" value="3">Plano Completo – valor + 12%</p>
                    </fieldset>
                    <input type="submit">
                </form>
                <?php
                    $nome = $_GET['nome'];
                    $valor = $_GET['valor'];
                    $plan = $_GET['plan'];
                    echo "<p>$nome</p>";
                    switch ($plan){
                        case 1 :
                            echo "Plano: Anti-stress.";
                            $tot = $valor * 0.06;
                            $valor1 = $valor + $tot;
                            break;
                        case 2 :
                            echo "Plano: Reeducação.";
                            $tot = $valor * 0.08;
                            $valor1 = $valor + $tot;
                            break;
                        case 3 :
                            echo "Plano: Completo";
                            $tot = $valor * 0.12;
                            $valor1 = $valor + $tot;
                            break;
                    }
                    echo "<p>O valor total foi de R$$valor1</p>";
                ?>
            </section>
            <footer>
                <em>&copyMatheus Andreoli 2ºY Nº20 </em>
            </footer>
        </div>
    </body>
</html>