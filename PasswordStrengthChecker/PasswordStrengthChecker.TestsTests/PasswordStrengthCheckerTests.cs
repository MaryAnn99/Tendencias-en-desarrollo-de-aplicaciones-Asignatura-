using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PasswordStrengthChecker.Tests.Tests
{
    [TestClass()]
    public class PasswordStrengthCheckerTests
    {
        [TestMethod()]
        public void Checker_When_a_return_strong()
        {
            string input = "&*%93*a";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }

        [TestMethod()]
        public void Checker_When_b_return_strong()
        {
            string input = "&*%93b$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }

        [TestMethod()]
        public void Checker_When_c_return_strong()
        {
            string input = "&*%93c$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }

        [TestMethod()]
        public void Checker_When_d_return_strong()
        {
            string input = "&*%93d$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }

        [TestMethod()]
        public void Checker_When_e_return_strong()
        {
            string input = "&*%93e$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_f_return_strong()
        {
            string input = "&*%93f$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_g_return_strong()
        {
            string input = "&*%93g$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_h_return_strong()
        {
            string input = "&*%93h$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_i_return_strong()
        {
            string input = "&*%93i$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_j_return_strong()
        {
            string input = "&*%93j$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_k_return_strong()
        {
            string input = "&*%93k$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_l_return_strong()
        {
            string input = "&*%93l$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_m_return_strong()
        {
            string input = "&*%93m$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_n_return_strong()
        {
            string input = "&*%93n$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_o_return_strong()
        {
            string input = "&*%93o$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_p_return_strong()
        {
            string input = "&*%93p$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_q_return_strong()
        {
            string input = "&*%93q$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_r_return_strong()
        {
            string input = "&*%93r$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_s_return_strong()
        {
            string input = "&*%93s$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_t_return_strong()
        {
            string input = "&*%93t$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }

        [TestMethod()]
        public void Checker_When_u_return_strong()
        {
            string input = "&*%93u$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_v_return_strong()
        {
            string input = "&*%93v$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_w_return_strong()
        {
            string input = "&*%93w$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_x_return_strong()
        {
            string input = "&*%93x$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_y_return_strong()
        {
            string input = "&*%93y$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_z_return_strong()
        {
            string input = "&*%93z$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }


        [TestMethod()]
        public void Checker_When_A_return_strong()
        {
            string input = "&*%93*A";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }

        
        [TestMethod()]
        public void Checker_When_B_return_strong()
        {
            string input = "&*%93B$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        
        [TestMethod()]
        public void Checker_When_C_return_strong()
        {
            string input = "&*%93C$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        
        [TestMethod()]
        public void Checker_When_D_return_strong()
        {
            string input = "&*%93D$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }

        [TestMethod()]
        public void Checker_When_E_return_strong()
        {
            string input = "&*%93E$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_F_return_strong()
        {
            string input = "&*%93F$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_G_return_strong()
        {
            string input = "&*%93G$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_H_return_strong()
        {
            string input = "&*%93H$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_I_return_strong()
        {
            string input = "&*%93I$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_J_return_strong()
        {
            string input = "&*%93J$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_K_return_strong()
        {
            string input = "&*%93K$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_L_return_strong()
        {
            string input = "&*%93L$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_M_return_strong()
        {
            string input = "&*%93M$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_N_return_strong()
        {
            string input = "&*%93N$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_O_return_strong()
        {
            string input = "&*%93O$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_P_return_strong()
        {
            string input = "&*%93P$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_Q_return_strong()
        {
            string input = "&*%93Q$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_R_return_strong()
        {
            string input = "&*%93R$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_S_return_strong()
        {
            string input = "&*%93S$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_T_return_strong()
        {
            string input = "&*%93T$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }

        [TestMethod()]
        public void Checker_When_U_return_strong()
        {
            string input = "&*%93U$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_V_return_strong()
        {
            string input = "&*%93V$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_W_return_strong()
        {
            string input = "&*%93W$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_X_return_strong()
        {
            string input = "&*%93X$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_Y_return_strong()
        {
            string input = "&*%93Y$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_Z_return_strong()
        {
            string input = "&*%93Z$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_0_return_strong()
        {
            string input = "&0%aB**";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }

        [TestMethod()]
        public void Checker_When_1_return_strong()
        {
            string input = "&1%aB**";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }

        [TestMethod()]
        public void Checker_When_2_return_strong()
        {
            string input = "&2%aB**";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }

        [TestMethod()]
        public void Checker_When_3_return_strong()
        {
            string input = "&3%aB**";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }

        [TestMethod()]
        public void Checker_When_4_return_strong()
        {
            string input = "&4%aB**";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }

        [TestMethod()]
        public void Checker_When_5_return_strong()
        {
            string input = "&5%aB**";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_6_return_strong()
        {
            string input = "&6%aB**";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_7_return_strong()
        {
            string input = "&7%aB**";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_8_return_strong()
        {
            string input = "&8%aB**";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_9_return_strong()
        {
            string input = "&9%aB**";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }

        [TestMethod()]
        public void Checker_When_LengthGreater7_return_strong()
        {
            string input = "*/****-++sdfiM9083";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es fuerte (strong)", output);
        }
        [TestMethod()]
        public void Checker_When_NoDigit_return_weak()
        {
            string input = "MJkUIsmoighoklndf";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es debil (weak)", output);
        }
        [TestMethod()]
        public void Checker_When_Empty_return_weakAndEmpty()
        {
            string input = "";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es débil (weak). La entrada está vacía", output);
        }
        [TestMethod()]
        public void Checker_When_NoChar_return_weak()
        {
            string input = "9999389483938";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es debil (weak)", output);
        }
        [TestMethod()]
        public void Checker_When_NoLength_return_weak()
        {
            string input = "MJ9";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es debil (weak)", output);
        }
        [TestMethod()]
        public void Checker_When_NoReq_return_weak()
        {
            string input = "******";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es debil (weak)", output);
        }

        [TestMethod()]
        public void Checker_When_NocharAndLength_return_weak()
        {
            string input = "8867$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es debil (weak)", output);
        }
        [TestMethod()]
        public void Checker_When_NoDigitAndLength_return_weak()
        {
            string input = "mm%$";
            string output = PasswordStrengthChecker.Checker(input);
            Assert.AreEqual("El password es debil (weak)", output);
        }
    }
}