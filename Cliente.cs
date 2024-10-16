namespace Recuperação_UC_12_e_13
{
    public class Cliente
    {
        public string? cpf_cnpj {get; set;}
        public string? nome { get; set; }
        public string? endereco { get; set; }
        public string? rg_ie { get; set; }
        public char? tipo { get; set; }
        public float valor { get; set; }
        public float valor_imposto { get; set; }    
        public float total { get; set; }
    }
}