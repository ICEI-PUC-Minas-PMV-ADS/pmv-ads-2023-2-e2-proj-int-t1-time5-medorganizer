using MedOrganizerE2.Models;
using System.Collections.Generic;


namespace MedOrganizerE2.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<ConsultaMedica> ConsultasMedicas { get; set; }
        public List<ExameMedico> ExamesMedicos { get; set; }

        // Construtor, métodos e propriedades adicionais, se necessário
    }
}