window.onload = function () {

    /*Запрет ввода букв для поля Цена*/
    document.getElementById('price').onkeypress = function BanSymbols(e) {
        return !(/[А-Яа-яA-Za-z-+*/,.]/.test(String.fromCharCode(e.charCode)));
    };

    /*Запрет ввода букв для поля Количество*/
    document.getElementById('quantity').onkeypress = function BanSymbols(e) {
        return !(/[А-Яа-яA-Za-z-+*/,.]/.test(String.fromCharCode(e.charCode)));
    };

    /*Функция подсчета суммы за один вид товара*/
    setInterval(function CalcSum() {
        document.getElementById('result').innerHTML = (parseFloat(document.getElementById('price').value) || 0) * (parseFloat(document.getElementById('quantity').value) || 0);
    }, 500);

    /*Отправка запроса на сервер*/
    function SubmitForm(product, price, quantity) {
        $.ajax(
            {
                method: "post",
                url: "/Home/Form",
                data: { Product: product, Price: price, Quantity: quantity }
            }).fail(function () {
                alert("При передаче данных произошла ошибка!");
            }).done(function (context) { //При успешной отправке получим ответ от сервера
                alert(context);
            });
    }

    $(document).on('submit', 'form', function () {
        var Product = $('select').val();
        var Price = $('input[name=Price]').val();
        var Quantity = $('input[name=Quantity]').val();

        SubmitForm(Product, Price, Quantity);
    });
}
