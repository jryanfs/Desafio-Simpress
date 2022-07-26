var AttProduto = (id) => {
    var href = `/Produto/GetProduto/${id}`;
    $.get(href, (response) => {
        $("#Id").val(response.id);
        $("#Nome").val(response.nome);
        $("#Descricao").val(response.descricao);
        $("#CategoriaId").val(response.categoriaId);
        response.perecivel == true ? $('#Perecivel').attr('checked', true) : $('#Perecivel').attr('checked', false);
    });
}

$("#btnCadastrar").on("click", (e) => {

    var nome = $("#Nome").val();
    var descricao = $("#Descricao").val();

    if (nome == "") {
        e.preventDefault();
        return alert("Por favor Preencha nome!");
    }
    if (descricao == "") {
        e.preventDefault();
        return alert("Por favor Preencha descricao!");
    }
});