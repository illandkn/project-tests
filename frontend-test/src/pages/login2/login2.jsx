import React from "react";
import "../login2/login2.css";

function LoginPage() {
  return (
      <body className="login-body">
        <main className="login-container">
          <h2 className="login-h2">Login</h2>
          <form className="login-form" action="">
            <div class="login-input-field">
              <input
                type="text"
                name="login"
                id="login"
                placeholder="Login"
              />
              <div class="login-underline"></div>
            </div>
            <div class="login-input-field">
              <input
                type="password"
                name="password"
                id="password"
                placeholder="Senha"
              />
              <div class="login-underline"></div>
            </div>

            <input type="submit" value="Enviar" />
          </form>

          <div class="login-footer">
            <a href="/form2">Não possui login?</a>
          </div>
        </main>
      </body>
  );
}

export default LoginPage;
