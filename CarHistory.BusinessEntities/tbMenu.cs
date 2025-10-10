namespace CarHistory.BusinessEntities
{
    public class tbMenu
    {
        public string menuId { get; set; }
        public string menuNombre { get; set; }
        public string menuNomControl { get; set; }
        public string menuNomNameSpace { get; set; }
        public string menuNomFormulario { get; set; }
        public string menuActividad { get; set; }
        public int menuEstado { get; set; }
        public int rolId { get; set; }

        public tbMenu()
        {
            menuId = string.Empty;
            menuNombre = string.Empty;
            menuNomControl = string.Empty;
            menuNomNameSpace = string.Empty;
            menuNomFormulario = string.Empty;
            menuActividad = string.Empty;
            menuEstado = 0;

            rolId = 0;
        }
    }
}
