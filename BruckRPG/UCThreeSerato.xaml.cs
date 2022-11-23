using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BruckRPG
{
    /// <summary>
    /// Interação lógica para UCThreeSerato.xam
    /// </summary>
    public partial class UCThreeSerato : UserControl
    {
        public UCThreeSerato()
        {
            InitializeComponent();
        }
        private void btnJogar_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();

            //For first spell
            int iRnd = new int();
            iRnd = r.Next(1, 125);

            if (iRnd == 1)
                magia1.Text = new string("ALARME -1");
            else if (iRnd == 2)
                magia1.Text = new string("ARMADURA ARCANA -1");
            else if (iRnd == 3)
                magia1.Text = new string("RESISTENCIA A ENERGIA -1");
            else if (iRnd == 4)
                magia1.Text = new string("TRANCA ARCANA -1");
            else if (iRnd == 5)
                magia1.Text = new string("AVISO -1");
            else if (iRnd == 6)
                magia1.Text = new string("COMPREENSAO -1");
            else if (iRnd == 7)
                magia1.Text = new string("CONCENTRACAO DE COMBATE -1");
            else if (iRnd == 8)
                magia1.Text = new string("VISAO MISTICA -1");
            else if (iRnd == 9)
                magia1.Text = new string("AREA ESCORREGADIA -1");
            else if (iRnd == 10)
                magia1.Text = new string("CONJURAR MONSTRO -1");
            else if (iRnd == 11)
                magia1.Text = new string("NEVOA -1");
            else if (iRnd == 12)
                magia1.Text = new string("TEIA -1");
            else if (iRnd == 13)
                magia1.Text = new string("ADAGA MENTAL -1");
            else if (iRnd == 14)
                magia1.Text = new string("ENFEITICAR -1");
            else if (iRnd == 15)
                magia1.Text = new string("HIPNOTISMO -1");
            else if (iRnd == 16)
                magia1.Text = new string("SONO -1");
            else if (iRnd == 17)
                magia1.Text = new string("EXPLOSAO DE CHAMAS -1");
            else if (iRnd == 18)
                magia1.Text = new string("LUZ -1");
            else if (iRnd == 19)
                magia1.Text = new string("SETA INFALIVEL DE TALUDE -1");
            else if (iRnd == 20)
                magia1.Text = new string("TOQUE CHOCANTE -1");
            else if (iRnd == 21)
                magia1.Text = new string("CRIAR ILUSAO -1");
            else if (iRnd == 22)
                magia1.Text = new string("DESFARCE ILUSORIO -1");
            else if (iRnd == 23)
                magia1.Text = new string("IMAGEM ESPELHADA -1");
            else if (iRnd == 24)
                magia1.Text = new string("LEQUE CROMATICO -1");
            else if (iRnd == 25)
                magia1.Text = new string("AMEDRONTAR -1");
            else if (iRnd == 26)
                magia1.Text = new string("ESCURIDAO -1");
            else if (iRnd == 27)
                magia1.Text = new string("RAIO DO ENFRAQUECIMENTO -1");
            else if (iRnd == 28)
                magia1.Text = new string("VITALIDADE FANTASMA");
            else if (iRnd == 29)
                magia1.Text = new string("ARMA MAGICA -1");
            else if (iRnd == 30)
                magia1.Text = new string("PRIMOR ATLETICO -1");
            else if (iRnd == 31)
                magia1.Text = new string("QUEDA SUAVE -1");
            else if (iRnd == 32)
                magia1.Text = new string("TRANSMUTAR OBJETOS -1");
            else if (iRnd == 33)
                magia1.Text = new string("CAMPO DE FORCA -2");
            else if (iRnd == 34)
                magia1.Text = new string("DISSIPAR MAGIA -2");
            else if (iRnd == 35)
                magia1.Text = new string("REFUGIO -2");
            else if (iRnd == 36)
                magia1.Text = new string("RUNA DE PROTECAO -2");
            else if (iRnd == 37)
                magia1.Text = new string("LIGACAO TELEPATICA -2");
            else if (iRnd == 38)
                magia1.Text = new string("LOCALIZACAO -2");
            else if (iRnd == 39)
                magia1.Text = new string("MAPEAR -2");
            else if (iRnd == 40)
                magia1.Text = new string("AMARRAS ETEREAS -2");
            else if (iRnd == 41)
                magia1.Text = new string("MONTARIA ARCANA -2");
            else if (iRnd == 42)
                magia1.Text = new string("SALTO DIMENSIONAL -2");
            else if (iRnd == 43)
                magia1.Text = new string("SERVOS INVISIVEIS -2");
            else if (iRnd == 44)
                magia1.Text = new string("DESESPERO ESMAGADOR -2");
            else if (iRnd == 45)
                magia1.Text = new string("MARCA DA OBDIENCIA -2");
            else if (iRnd == 46)
                magia1.Text = new string("SUSURROS INSANOS -2");
            else if (iRnd == 47)
                magia1.Text = new string("BOLA DE FOGO -2");
            else if (iRnd == 48)
                magia1.Text = new string("FLECHA ACIDA -2");
            else if (iRnd == 49)
                magia1.Text = new string("RELAMPAGO -2");
            else if (iRnd == 50)
                magia1.Text = new string("SOPRO DAS UIVANTES -2");
            else if (iRnd == 51)
                magia1.Text = new string("APARENCIA PERFEITA -2");
            else if (iRnd == 52)
                magia1.Text = new string("CAMUFLAGEM ILUSORIA -2");
            else if (iRnd == 53)
                magia1.Text = new string("ESCULPIR SONS -2");
            else if (iRnd == 54)
                magia1.Text = new string("INVISIBILIDADE -2");
            else if (iRnd == 55)
                magia1.Text = new string("CONJURAR MORTOS VIVOS -2");
            else if (iRnd == 56)
                magia1.Text = new string("CRANIO VOADOR DE VLADIMIR -2");
            else if (iRnd == 57)
                magia1.Text = new string("TOQUE VAMPIRICO -2");
            else if (iRnd == 58)
                magia1.Text = new string("ALTERAR TAMANHO -2");
            else if (iRnd == 59)
                magia1.Text = new string("METAMORFOSE -2");
            else if (iRnd == 60)
                magia1.Text = new string("VELOCIDADE -2");
            else if (iRnd == 61)
                magia1.Text = new string("ANCORA DIMENSIONAL -3");
            else if (iRnd == 62)
                magia1.Text = new string("DIFICULTAR DETECCAO -3");
            else if (iRnd == 63)
                magia1.Text = new string("GLOBO DE INVULNERABILIDADE -3");
            else if (iRnd == 64)
                magia1.Text = new string("CONTATO EXTRAPLANAR -3");
            else if (iRnd == 65)
                magia1.Text = new string("LENDAS E HISTORIAS -3");
            else if (iRnd == 66)
                magia1.Text = new string("VIDENCIA -3");
            else if (iRnd == 67)
                magia1.Text = new string("CONVOCACAO INSTANTANEA -3");
            else if (iRnd == 68)
                magia1.Text = new string("ENXAME RUBRO DE INCHABODE -3");
            else if (iRnd == 69)
                magia1.Text = new string("TELETRANSPORTE -3");
            else if (iRnd == 70)
                magia1.Text = new string("SELO DE MANA -3");
            else if (iRnd == 71)
                magia1.Text = new string("ERUPCAO GLACIAL -3");
            else if (iRnd == 72)
                magia1.Text = new string("LANCA IGNEA DE ALEPH -3");
            else if (iRnd == 73)
                magia1.Text = new string("MURALHA ELEMENTAL -3");
            else if (iRnd == 74)
                magia1.Text = new string("ILUSAO LACERANTE -3");
            else if (iRnd == 75)
                magia1.Text = new string("MANTO DE SOMBRAS -3");
            else if (iRnd == 76)
                magia1.Text = new string("MIRAGEM -3");
            else if (iRnd == 77)
                magia1.Text = new string("FERVER SANGUE -3");
            else if (iRnd == 78)
                magia1.Text = new string("SERVO MORTO VIVO -3");
            else if (iRnd == 79)
                magia1.Text = new string("TENTACULOS DE TREVAS -3");
            else if (iRnd == 80)
                magia1.Text = new string("PELE DE PEDRA -3");
            else if (iRnd == 81)
                magia1.Text = new string("TELECINESIA -3");
            else if (iRnd == 82)
                magia1.Text = new string("TRANSFORMACAO DE GUERRA -3");
            else if (iRnd == 83)
                magia1.Text = new string("VOO -3");
            else if (iRnd == 84)
                magia1.Text = new string("CAMPO ANTI MAGIA -4");
            else if (iRnd == 85)
                magia1.Text = new string("CAMPO ANTI MAGIA -4");
            else if (iRnd == 86)
                magia1.Text = new string("LIBERTACAO -4");
            else if (iRnd == 87)
                magia1.Text = new string("LIBERTACAO -4");
            else if (iRnd == 88)
                magia1.Text = new string("SONHO -4");
            else if (iRnd == 89)
                magia1.Text = new string("SONHO -4");
            else if (iRnd == 90)
                magia1.Text = new string("VISAO DA VERDADE -4");
            else if (iRnd == 91)
                magia1.Text = new string("VISAO DA VERDADE -4");
            else if (iRnd == 92)
                magia1.Text = new string("CONJURAR ELEMENTAL -4");
            else if (iRnd == 93)
                magia1.Text = new string("CONJURAR ELEMENTAL -4");
            else if (iRnd == 94)
                magia1.Text = new string("MAO PODEROSA DE TALUDE -4");
            else if (iRnd == 95)
                magia1.Text = new string("MAO PODEROSA DE TALUDE -4");
            else if (iRnd == 96)
                magia1.Text = new string("VIAGEM PLANAR -4");
            else if (iRnd == 97)
                magia1.Text = new string("VIAGEM PLANAR -4");
            else if (iRnd == 98)
                magia1.Text = new string("ALTERAR MEMORIA -4");
            else if (iRnd == 99)
                magia1.Text = new string("ALTERAR MEMORIA -4");
            else if (iRnd == 100)
                magia1.Text = new string("MARIONETE -4");
            else if (iRnd == 102)
                magia1.Text = new string("MARIONETE -4");
            else if (iRnd == 103)
                magia1.Text = new string("RAIO POLAR -4");
            else if (iRnd == 104)
                magia1.Text = new string("RAIO POLAR -4");
            else if (iRnd == 105)
                magia1.Text = new string("RELAMPAGO FLAMEJANTE -4");
            else if (iRnd == 106)
                magia1.Text = new string("RELAMPAGO FLAMEJANTE -4");
            else if (iRnd == 107)
                magia1.Text = new string("TALHO INVISIVEL -4");
            else if (iRnd == 108)
                magia1.Text = new string("TALHO INVISIVEL -4");
            else if (iRnd == 109)
                magia1.Text = new string("DUPLICATA ILUSORIA -4");
            else if (iRnd == 110)
                magia1.Text = new string("DUPLICATA ILUSORIA -4");
            else if (iRnd == 111)
                magia1.Text = new string("EXPLOSAO CALEIDOSCOPIA -4");
            else if (iRnd == 112)
                magia1.Text = new string("EXPLOSAO CALEIDOSCOPIA -4");
            else if (iRnd == 113)
                magia1.Text = new string("ASSASINO FANTASMAGORICO -4");
            else if (iRnd == 114)
                magia1.Text = new string("ASSASINO FANTASMAGORICO -4");
            else if (iRnd == 115)
                magia1.Text = new string("MURALHA DE OSSOS -4");
            else if (iRnd == 116)
                magia1.Text = new string("MURALHA DE OSSOS -4");
            else if (iRnd == 117)
                magia1.Text = new string("ANIMAR OBJETOS -4");
            else if (iRnd == 118)
                magia1.Text = new string("ANIMAR OBJETOS -4");
            else if (iRnd == 119)
                magia1.Text = new string("CONTROLAR A GRAVIDADE -4");
            else if (iRnd == 120)
                magia1.Text = new string("CONTROLAR A GRAVIDADE -4");
            else if (iRnd == 121)
                magia1.Text = new string("DESISTEGRAR -4");
            else if (iRnd == 122)
                magia1.Text = new string("DESISTEGRAR -4");
            else if (iRnd == 123)
                magia1.Text = new string("FORMA ETERIA -4");
            else if (iRnd == 124)
                magia1.Text = new string("FORMA ETERIA -4");


            //FOR SECOND SPELL
            iRnd = r.Next(1, 125);

            if (iRnd == 1)
                magia2.Text = new string("ALARME -1");
            else if (iRnd == 2)
                magia2.Text = new string("ARMADURA ARCANA -1");
            else if (iRnd == 3)
                magia2.Text = new string("RESISTENCIA A ENERGIA -1");
            else if (iRnd == 4)
                magia2.Text = new string("TRANCA ARCANA -1");
            else if (iRnd == 5)
                magia2.Text = new string("AVISO -1");
            else if (iRnd == 6)
                magia2.Text = new string("COMPREENSAO -1");
            else if (iRnd == 7)
                magia2.Text = new string("CONCENTRACAO DE COMBATE -1");
            else if (iRnd == 8)
                magia2.Text = new string("VISAO MISTICA -1");
            else if (iRnd == 9)
                magia2.Text = new string("AREA ESCORREGADIA -1");
            else if (iRnd == 10)
                magia2.Text = new string("CONJURAR MONSTRO -1");
            else if (iRnd == 11)
                magia2.Text = new string("NEVOA -1");
            else if (iRnd == 12)
                magia2.Text = new string("TEIA -1");
            else if (iRnd == 13)
                magia2.Text = new string("ADAGA MENTAL -1");
            else if (iRnd == 14)
                magia2.Text = new string("ENFEITICAR -1");
            else if (iRnd == 15)
                magia2.Text = new string("HIPNOTISMO -1");
            else if (iRnd == 16)
                magia2.Text = new string("SONO -1");
            else if (iRnd == 17)
                magia2.Text = new string("EXPLOSAO DE CHAMAS -1");
            else if (iRnd == 18)
                magia2.Text = new string("LUZ -1");
            else if (iRnd == 19)
                magia2.Text = new string("SETA INFALIVEL DE TALUDE -1");
            else if (iRnd == 20)
                magia2.Text = new string("TOQUE CHOCANTE -1");
            else if (iRnd == 21)
                magia2.Text = new string("CRIAR ILUSAO -1");
            else if (iRnd == 22)
                magia2.Text = new string("DESFARCE ILUSORIO -1");
            else if (iRnd == 23)
                magia2.Text = new string("IMAGEM ESPELHADA -1");
            else if (iRnd == 24)
                magia2.Text = new string("LEQUE CROMATICO -1");
            else if (iRnd == 25)
                magia2.Text = new string("AMEDRONTAR -1");
            else if (iRnd == 26)
                magia2.Text = new string("ESCURIDAO -1");
            else if (iRnd == 27)
                magia2.Text = new string("RAIO DO ENFRAQUECIMENTO -1");
            else if (iRnd == 28)
                magia2.Text = new string("VITALIDADE FANTASMA");
            else if (iRnd == 29)
                magia2.Text = new string("ARMA MAGICA -1");
            else if (iRnd == 30)
                magia2.Text = new string("PRIMOR ATLETICO -1");
            else if (iRnd == 31)
                magia2.Text = new string("QUEDA SUAVE -1");
            else if (iRnd == 32)
                magia2.Text = new string("TRANSMUTAR OBJETOS -1");
            else if (iRnd == 33)
                magia2.Text = new string("CAMPO DE FORCA -2");
            else if (iRnd == 34)
                magia2.Text = new string("DISSIPAR MAGIA -2");
            else if (iRnd == 35)
                magia2.Text = new string("REFUGIO -2");
            else if (iRnd == 36)
                magia2.Text = new string("RUNA DE PROTECAO -2");
            else if (iRnd == 37)
                magia2.Text = new string("LIGACAO TELEPATICA -2");
            else if (iRnd == 38)
                magia2.Text = new string("LOCALIZACAO -2");
            else if (iRnd == 39)
                magia2.Text = new string("MAPEAR -2");
            else if (iRnd == 40)
                magia2.Text = new string("AMARRAS ETEREAS -2");
            else if (iRnd == 41)
                magia2.Text = new string("MONTARIA ARCANA -2");
            else if (iRnd == 42)
                magia2.Text = new string("SALTO DIMENSIONAL -2");
            else if (iRnd == 43)
                magia2.Text = new string("SERVOS INVISIVEIS -2");
            else if (iRnd == 44)
                magia2.Text = new string("DESESPERO ESMAGADOR -2");
            else if (iRnd == 45)
                magia2.Text = new string("MARCA DA OBDIENCIA -2");
            else if (iRnd == 46)
                magia2.Text = new string("SUSURROS INSANOS -2");
            else if (iRnd == 47)
                magia2.Text = new string("BOLA DE FOGO -2");
            else if (iRnd == 48)
                magia2.Text = new string("FLECHA ACIDA -2");
            else if (iRnd == 49)
                magia2.Text = new string("RELAMPAGO -2");
            else if (iRnd == 50)
                magia2.Text = new string("SOPRO DAS UIVANTES -2");
            else if (iRnd == 51)
                magia2.Text = new string("APARENCIA PERFEITA -2");
            else if (iRnd == 52)
                magia2.Text = new string("CAMUFLAGEM ILUSORIA -2");
            else if (iRnd == 53)
                magia2.Text = new string("ESCULPIR SONS -2");
            else if (iRnd == 54)
                magia2.Text = new string("INVISIBILIDADE -2");
            else if (iRnd == 55)
                magia2.Text = new string("CONJURAR MORTOS VIVOS -2");
            else if (iRnd == 56)
                magia2.Text = new string("CRANIO VOADOR DE VLADIMIR -2");
            else if (iRnd == 57)
                magia2.Text = new string("TOQUE VAMPIRICO -2");
            else if (iRnd == 58)
                magia2.Text = new string("ALTERAR TAMANHO -2");
            else if (iRnd == 59)
                magia2.Text = new string("METAMORFOSE -2");
            else if (iRnd == 60)
                magia2.Text = new string("VELOCIDADE -2");
            else if (iRnd == 61)
                magia2.Text = new string("ANCORA DIMENSIONAL -3");
            else if (iRnd == 62)
                magia2.Text = new string("DIFICULTAR DETECCAO -3");
            else if (iRnd == 63)
                magia2.Text = new string("GLOBO DE INVULNERABILIDADE -3");
            else if (iRnd == 64)
                magia2.Text = new string("CONTATO EXTRAPLANAR -3");
            else if (iRnd == 65)
                magia2.Text = new string("LENDAS E HISTORIAS -3");
            else if (iRnd == 66)
                magia2.Text = new string("VIDENCIA -3");
            else if (iRnd == 67)
                magia2.Text = new string("CONVOCACAO INSTANTANEA -3");
            else if (iRnd == 68)
                magia2.Text = new string("ENXAME RUBRO DE INCHABODE -3");
            else if (iRnd == 69)
                magia2.Text = new string("TELETRANSPORTE -3");
            else if (iRnd == 70)
                magia2.Text = new string("SELO DE MANA -3");
            else if (iRnd == 71)
                magia2.Text = new string("ERUPCAO GLACIAL -3");
            else if (iRnd == 72)
                magia2.Text = new string("LANCA IGNEA DE ALEPH -3");
            else if (iRnd == 73)
                magia2.Text = new string("MURALHA ELEMENTAL -3");
            else if (iRnd == 74)
                magia2.Text = new string("ILUSAO LACERANTE -3");
            else if (iRnd == 75)
                magia2.Text = new string("MANTO DE SOMBRAS -3");
            else if (iRnd == 76)
                magia2.Text = new string("MIRAGEM -3");
            else if (iRnd == 77)
                magia2.Text = new string("FERVER SANGUE -3");
            else if (iRnd == 78)
                magia2.Text = new string("SERVO MORTO VIVO -3");
            else if (iRnd == 79)
                magia2.Text = new string("TENTACULOS DE TREVAS -3");
            else if (iRnd == 80)
                magia2.Text = new string("PELE DE PEDRA -3");
            else if (iRnd == 81)
                magia2.Text = new string("TELECINESIA -3");
            else if (iRnd == 82)
                magia2.Text = new string("TRANSFORMACAO DE GUERRA -3");
            else if (iRnd == 83)
                magia2.Text = new string("VOO -3");
            else if (iRnd == 84)
                magia2.Text = new string("CAMPO ANTI MAGIA -4");
            else if (iRnd == 85)
                magia2.Text = new string("CAMPO ANTI MAGIA -4");
            else if (iRnd == 86)
                magia2.Text = new string("LIBERTACAO -4");
            else if (iRnd == 87)
                magia2.Text = new string("LIBERTACAO -4");
            else if (iRnd == 88)
                magia2.Text = new string("SONHO -4");
            else if (iRnd == 89)
                magia2.Text = new string("SONHO -4");
            else if (iRnd == 90)
                magia2.Text = new string("VISAO DA VERDADE -4");
            else if (iRnd == 91)
                magia2.Text = new string("VISAO DA VERDADE -4");
            else if (iRnd == 92)
                magia2.Text = new string("CONJURAR ELEMENTAL -4");
            else if (iRnd == 93)
                magia2.Text = new string("CONJURAR ELEMENTAL -4");
            else if (iRnd == 94)
                magia2.Text = new string("MAO PODEROSA DE TALUDE -4");
            else if (iRnd == 95)
                magia2.Text = new string("MAO PODEROSA DE TALUDE -4");
            else if (iRnd == 96)
                magia2.Text = new string("VIAGEM PLANAR -4");
            else if (iRnd == 97)
                magia2.Text = new string("VIAGEM PLANAR -4");
            else if (iRnd == 98)
                magia2.Text = new string("ALTERAR MEMORIA -4");
            else if (iRnd == 99)
                magia2.Text = new string("ALTERAR MEMORIA -4");
            else if (iRnd == 100)
                magia2.Text = new string("MARIONETE -4");
            else if (iRnd == 102)
                magia2.Text = new string("MARIONETE -4");
            else if (iRnd == 103)
                magia2.Text = new string("RAIO POLAR -4");
            else if (iRnd == 104)
                magia2.Text = new string("RAIO POLAR -4");
            else if (iRnd == 105)
                magia2.Text = new string("RELAMPAGO FLAMEJANTE -4");
            else if (iRnd == 106)
                magia2.Text = new string("RELAMPAGO FLAMEJANTE -4");
            else if (iRnd == 107)
                magia2.Text = new string("TALHO INVISIVEL -4");
            else if (iRnd == 108)
                magia2.Text = new string("TALHO INVISIVEL -4");
            else if (iRnd == 109)
                magia2.Text = new string("DUPLICATA ILUSORIA -4");
            else if (iRnd == 110)
                magia2.Text = new string("DUPLICATA ILUSORIA -4");
            else if (iRnd == 111)
                magia2.Text = new string("EXPLOSAO CALEIDOSCOPIA -4");
            else if (iRnd == 112)
                magia2.Text = new string("EXPLOSAO CALEIDOSCOPIA -4");
            else if (iRnd == 113)
                magia2.Text = new string("ASSASINO FANTASMAGORICO -4");
            else if (iRnd == 114)
                magia2.Text = new string("ASSASINO FANTASMAGORICO -4");
            else if (iRnd == 115)
                magia2.Text = new string("MURALHA DE OSSOS -4");
            else if (iRnd == 116)
                magia2.Text = new string("MURALHA DE OSSOS -4");
            else if (iRnd == 117)
                magia2.Text = new string("ANIMAR OBJETOS -4");
            else if (iRnd == 118)
                magia2.Text = new string("ANIMAR OBJETOS -4");
            else if (iRnd == 119)
                magia2.Text = new string("CONTROLAR A GRAVIDADE -4");
            else if (iRnd == 120)
                magia2.Text = new string("CONTROLAR A GRAVIDADE -4");
            else if (iRnd == 121)
                magia2.Text = new string("DESISTEGRAR -4");
            else if (iRnd == 122)
                magia2.Text = new string("DESISTEGRAR -4");
            else if (iRnd == 123)
                magia2.Text = new string("FORMA ETERIA -4");
            else if (iRnd == 124)
                magia2.Text = new string("FORMA ETERIA -4");



            //FOR THIRD SPELL
            iRnd = r.Next(1, 125);

            if (iRnd == 1)
                magia3.Text = new string("ALARME -1");
            else if (iRnd == 2)
                magia3.Text = new string("ARMADURA ARCANA -1");
            else if (iRnd == 3)
                magia3.Text = new string("RESISTENCIA A ENERGIA -1");
            else if (iRnd == 4)
                magia3.Text = new string("TRANCA ARCANA -1");
            else if (iRnd == 5)
                magia3.Text = new string("AVISO -1");
            else if (iRnd == 6)
                magia3.Text = new string("COMPREENSAO -1");
            else if (iRnd == 7)
                magia3.Text = new string("CONCENTRACAO DE COMBATE -1");
            else if (iRnd == 8)
                magia3.Text = new string("VISAO MISTICA -1");
            else if (iRnd == 9)
                magia3.Text = new string("AREA ESCORREGADIA -1");
            else if (iRnd == 10)
                magia3.Text = new string("CONJURAR MONSTRO -1");
            else if (iRnd == 11)
                magia3.Text = new string("NEVOA -1");
            else if (iRnd == 12)
                magia3.Text = new string("TEIA -1");
            else if (iRnd == 13)
                magia3.Text = new string("ADAGA MENTAL -1");
            else if (iRnd == 14)
                magia3.Text = new string("ENFEITICAR -1");
            else if (iRnd == 15)
                magia3.Text = new string("HIPNOTISMO -1");
            else if (iRnd == 16)
                magia3.Text = new string("SONO -1");
            else if (iRnd == 17)
                magia3.Text = new string("EXPLOSAO DE CHAMAS -1");
            else if (iRnd == 18)
                magia3.Text = new string("LUZ -1");
            else if (iRnd == 19)
                magia3.Text = new string("SETA INFALIVEL DE TALUDE -1");
            else if (iRnd == 20)
                magia3.Text = new string("TOQUE CHOCANTE -1");
            else if (iRnd == 21)
                magia3.Text = new string("CRIAR ILUSAO -1");
            else if (iRnd == 22)
                magia3.Text = new string("DESFARCE ILUSORIO -1");
            else if (iRnd == 23)
                magia3.Text = new string("IMAGEM ESPELHADA -1");
            else if (iRnd == 24)
                magia3.Text = new string("LEQUE CROMATICO -1");
            else if (iRnd == 25)
                magia3.Text = new string("AMEDRONTAR -1");
            else if (iRnd == 26)
                magia3.Text = new string("ESCURIDAO -1");
            else if (iRnd == 27)
                magia3.Text = new string("RAIO DO ENFRAQUECIMENTO -1");
            else if (iRnd == 28)
                magia3.Text = new string("VITALIDADE FANTASMA");
            else if (iRnd == 29)
                magia3.Text = new string("ARMA MAGICA -1");
            else if (iRnd == 30)
                magia3.Text = new string("PRIMOR ATLETICO -1");
            else if (iRnd == 31)
                magia3.Text = new string("QUEDA SUAVE -1");
            else if (iRnd == 32)
                magia3.Text = new string("TRANSMUTAR OBJETOS -1");
            else if (iRnd == 33)
                magia3.Text = new string("CAMPO DE FORCA -2");
            else if (iRnd == 34)
                magia3.Text = new string("DISSIPAR MAGIA -2");
            else if (iRnd == 35)
                magia3.Text = new string("REFUGIO -2");
            else if (iRnd == 36)
                magia3.Text = new string("RUNA DE PROTECAO -2");
            else if (iRnd == 37)
                magia3.Text = new string("LIGACAO TELEPATICA -2");
            else if (iRnd == 38)
                magia3.Text = new string("LOCALIZACAO -2");
            else if (iRnd == 39)
                magia3.Text = new string("MAPEAR -2");
            else if (iRnd == 40)
                magia3.Text = new string("AMARRAS ETEREAS -2");
            else if (iRnd == 41)
                magia3.Text = new string("MONTARIA ARCANA -2");
            else if (iRnd == 42)
                magia3.Text = new string("SALTO DIMENSIONAL -2");
            else if (iRnd == 43)
                magia3.Text = new string("SERVOS INVISIVEIS -2");
            else if (iRnd == 44)
                magia3.Text = new string("DESESPERO ESMAGADOR -2");
            else if (iRnd == 45)
                magia3.Text = new string("MARCA DA OBDIENCIA -2");
            else if (iRnd == 46)
                magia3.Text = new string("SUSURROS INSANOS -2");
            else if (iRnd == 47)
                magia3.Text = new string("BOLA DE FOGO -2");
            else if (iRnd == 48)
                magia3.Text = new string("FLECHA ACIDA -2");
            else if (iRnd == 49)
                magia3.Text = new string("RELAMPAGO -2");
            else if (iRnd == 50)
                magia3.Text = new string("SOPRO DAS UIVANTES -2");
            else if (iRnd == 51)
                magia3.Text = new string("APARENCIA PERFEITA -2");
            else if (iRnd == 52)
                magia3.Text = new string("CAMUFLAGEM ILUSORIA -2");
            else if (iRnd == 53)
                magia3.Text = new string("ESCULPIR SONS -2");
            else if (iRnd == 54)
                magia3.Text = new string("INVISIBILIDADE -2");
            else if (iRnd == 55)
                magia3.Text = new string("CONJURAR MORTOS VIVOS -2");
            else if (iRnd == 56)
                magia3.Text = new string("CRANIO VOADOR DE VLADIMIR -2");
            else if (iRnd == 57)
                magia3.Text = new string("TOQUE VAMPIRICO -2");
            else if (iRnd == 58)
                magia3.Text = new string("ALTERAR TAMANHO -2");
            else if (iRnd == 59)
                magia3.Text = new string("METAMORFOSE -2");
            else if (iRnd == 60)
                magia3.Text = new string("VELOCIDADE -2");
            else if (iRnd == 61)
                magia3.Text = new string("ANCORA DIMENSIONAL -3");
            else if (iRnd == 62)
                magia3.Text = new string("DIFICULTAR DETECCAO -3");
            else if (iRnd == 63)
                magia3.Text = new string("GLOBO DE INVULNERABILIDADE -3");
            else if (iRnd == 64)
                magia3.Text = new string("CONTATO EXTRAPLANAR -3");
            else if (iRnd == 65)
                magia3.Text = new string("LENDAS E HISTORIAS -3");
            else if (iRnd == 66)
                magia3.Text = new string("VIDENCIA -3");
            else if (iRnd == 67)
                magia3.Text = new string("CONVOCACAO INSTANTANEA -3");
            else if (iRnd == 68)
                magia3.Text = new string("ENXAME RUBRO DE INCHABODE -3");
            else if (iRnd == 69)
                magia3.Text = new string("TELETRANSPORTE -3");
            else if (iRnd == 70)
                magia3.Text = new string("SELO DE MANA -3");
            else if (iRnd == 71)
                magia3.Text = new string("ERUPCAO GLACIAL -3");
            else if (iRnd == 72)
                magia3.Text = new string("LANCA IGNEA DE ALEPH -3");
            else if (iRnd == 73)
                magia3.Text = new string("MURALHA ELEMENTAL -3");
            else if (iRnd == 74)
                magia3.Text = new string("ILUSAO LACERANTE -3");
            else if (iRnd == 75)
                magia3.Text = new string("MANTO DE SOMBRAS -3");
            else if (iRnd == 76)
                magia3.Text = new string("MIRAGEM -3");
            else if (iRnd == 77)
                magia3.Text = new string("FERVER SANGUE -3");
            else if (iRnd == 78)
                magia3.Text = new string("SERVO MORTO VIVO -3");
            else if (iRnd == 79)
                magia3.Text = new string("TENTACULOS DE TREVAS -3");
            else if (iRnd == 80)
                magia3.Text = new string("PELE DE PEDRA -3");
            else if (iRnd == 81)
                magia3.Text = new string("TELECINESIA -3");
            else if (iRnd == 82)
                magia3.Text = new string("TRANSFORMACAO DE GUERRA -3");
            else if (iRnd == 83)
                magia3.Text = new string("VOO -3");
            else if (iRnd == 84)
                magia3.Text = new string("CAMPO ANTI MAGIA -4");
            else if (iRnd == 85)
                magia3.Text = new string("CAMPO ANTI MAGIA -4");
            else if (iRnd == 86)
                magia3.Text = new string("LIBERTACAO -4");
            else if (iRnd == 87)
                magia3.Text = new string("LIBERTACAO -4");
            else if (iRnd == 88)
                magia3.Text = new string("SONHO -4");
            else if (iRnd == 89)
                magia3.Text = new string("SONHO -4");
            else if (iRnd == 90)
                magia3.Text = new string("VISAO DA VERDADE -4");
            else if (iRnd == 91)
                magia3.Text = new string("VISAO DA VERDADE -4");
            else if (iRnd == 92)
                magia3.Text = new string("CONJURAR ELEMENTAL -4");
            else if (iRnd == 93)
                magia3.Text = new string("CONJURAR ELEMENTAL -4");
            else if (iRnd == 94)
                magia3.Text = new string("MAO PODEROSA DE TALUDE -4");
            else if (iRnd == 95)
                magia3.Text = new string("MAO PODEROSA DE TALUDE -4");
            else if (iRnd == 96)
                magia3.Text = new string("VIAGEM PLANAR -4");
            else if (iRnd == 97)
                magia3.Text = new string("VIAGEM PLANAR -4");
            else if (iRnd == 98)
                magia3.Text = new string("ALTERAR MEMORIA -4");
            else if (iRnd == 99)
                magia3.Text = new string("ALTERAR MEMORIA -4");
            else if (iRnd == 100)
                magia3.Text = new string("MARIONETE -4");
            else if (iRnd == 102)
                magia3.Text = new string("MARIONETE -4");
            else if (iRnd == 103)
                magia3.Text = new string("RAIO POLAR -4");
            else if (iRnd == 104)
                magia3.Text = new string("RAIO POLAR -4");
            else if (iRnd == 105)
                magia3.Text = new string("RELAMPAGO FLAMEJANTE -4");
            else if (iRnd == 106)
                magia3.Text = new string("RELAMPAGO FLAMEJANTE -4");
            else if (iRnd == 107)
                magia3.Text = new string("TALHO INVISIVEL -4");
            else if (iRnd == 108)
                magia3.Text = new string("TALHO INVISIVEL -4");
            else if (iRnd == 109)
                magia3.Text = new string("DUPLICATA ILUSORIA -4");
            else if (iRnd == 110)
                magia3.Text = new string("DUPLICATA ILUSORIA -4");
            else if (iRnd == 111)
                magia3.Text = new string("EXPLOSAO CALEIDOSCOPIA -4");
            else if (iRnd == 112)
                magia3.Text = new string("EXPLOSAO CALEIDOSCOPIA -4");
            else if (iRnd == 113)
                magia3.Text = new string("ASSASINO FANTASMAGORICO -4");
            else if (iRnd == 114)
                magia3.Text = new string("ASSASINO FANTASMAGORICO -4");
            else if (iRnd == 115)
                magia3.Text = new string("MURALHA DE OSSOS -4");
            else if (iRnd == 116)
                magia3.Text = new string("MURALHA DE OSSOS -4");
            else if (iRnd == 117)
                magia3.Text = new string("ANIMAR OBJETOS -4");
            else if (iRnd == 118)
                magia3.Text = new string("ANIMAR OBJETOS -4");
            else if (iRnd == 119)
                magia3.Text = new string("CONTROLAR A GRAVIDADE -4");
            else if (iRnd == 120)
                magia3.Text = new string("CONTROLAR A GRAVIDADE -4");
            else if (iRnd == 121)
                magia3.Text = new string("DESISTEGRAR -4");
            else if (iRnd == 122)
                magia3.Text = new string("DESISTEGRAR -4");
            else if (iRnd == 123)
                magia3.Text = new string("FORMA ETERIA -4");
            else if (iRnd == 124)
                magia3.Text = new string("FORMA ETERIA -4");

        }
    }
}
