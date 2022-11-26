import React, { useState } from "react";
import axios from "axios";
import "../form2/form2.css";

function FormPage() {
  const baseUrl = "https://localhost:7197/api/user";

  const [data, setData] = useState([]);

  const [userSelect, setUserSelect] = useState({
  nome: "",
  email: "",
  login: "",
  senha: "",
  role: 1,
  cpf: "",
  dataNascimento: "",
  genero: "",
  estadoCivil: "",
  escolaridade: "",
  curso: "",
  experienciaProfissional: "",
  pretensaoSalarial: 0,
  });

  const handleChange = (e) => {
    const { name, value } = e.target;
    setUserSelect({
      ...userSelect,
      [name]: value,
    });
    console.log(userSelect);
  };

  const pedidoPost = async () => {
    delete userSelect.id;
    await axios
      .post(baseUrl, userSelect)
      .then((response) => {
        setData(data.concat(response.data));
      })
      .catch((error) => {
        console.log(error);
      });
  };

  return (
    <div>
      <body className="form-body">
        <main class="form-container">
          <h2 className="form-h2">Formulário</h2>
          <form className="form-form" action="">
            <div className="form-input-field">
              <input
                required
                type="text"
                name="nome"
                onChange={handleChange}
                id="nome"
                placeholder="Nome"
              />
              <div className="form-underline"></div>
            </div>

            <div className="form-input-field">
              <input
                required
                type="text"
                name="email"
                onChange={handleChange}
                id="email"
                placeholder="E-mail"
              />
              <div className="form-underline"></div>
            </div>

            <div className="form-input-field">
              <input
                required
                type="text"
                name="login"
                onChange={handleChange}
                id="login"
                placeholder="Login"
              />
              <div className="form-underline"></div>
            </div>

            <div className="form-input-field">
              <input
                required
                type="password"
                name="senha"
                onChange={handleChange}
                id="senha"
                placeholder="Senha"
              />
              <div className="form-underline"></div>
            </div>

            <div className="form-input-field">
              <input
                required
                type="text"
                name="cpf"
                onChange={handleChange}
                id="cpf"
                placeholder="CPF"
              />
              <div className="form-underline"></div>
            </div>

            <div className="form-input-field">
              <input
                required
                type="text"
                name="dataNascimento"
                onChange={handleChange}
                id="dataNascimento"
                placeholder="Data de Nascimento"
              />
              <div className="form-underline"></div>
            </div>

            <div className="form-input-field">
              <select required name="genero" onChange={handleChange}>
                <option className="option" disabled selected value="">
                  Sexo
                </option>
                <option className="option" value="Masculino">
                  Masculino
                </option>
                <option className="option" value="Feminino">
                  Feminino
                </option>
              </select>
              <div className="form-underline"></div>
            </div>

            <div className="form-input-field">
              <select required name="estadoCivil" onChange={handleChange}>
                <option className="option" disabled selected value="">
                  Estado Civil
                </option>
                <option className="option" value="Solteiro(a)">
                  Solteiro(a)
                </option>
                <option className="option" value="Casado(a)">
                  Casado(a)
                </option>
                <option className="option" value="Divorciado(a)">
                  Divorciado(a)
                </option>
                <option className="option" value="Viúvo(a)">
                  {" "}
                  Viúvo(a)
                </option>
              </select>
              <div className="form-underline"></div>
            </div>

            <div className="form-input-field">
              <select required name="escolaridade" onChange={handleChange}>
                <option className="option" disabled selected value="">
                  Escolaridade
                </option>
                <option className="option" value="Ensino Médio Incompleto">
                  Ensino Médio Incompleto
                </option>
                <option className="option" value="Ensino Médio Completo">
                  Ensino Médio Completo
                </option>
                <option className="option" value="Ensino Superior Incompleto">
                  Ensino Superior Incompleto
                </option>
                <option className="option" value="Ensino Superior Completo">
                  Ensino Superior Completo
                </option>
                <option className="option" value="Pós-graduação">
                  Pós-graduação
                </option>
                <option className="option" value="Mestrado">
                  Mestrado
                </option>
                <option className="option" value="Doutorado">
                  Doutorado
                </option>
              </select>
              <div className="form-underline"></div>
            </div>

            <div className="form-input-field">
              <input
                required
                type="text"
                name="curso"
                onChange={handleChange}
                id="curso"
                placeholder="Cursos/ Especializações"
              />
              <div className="form-underline"></div>
            </div>

            <div className="form-input-field">
              <input
                required
                type="text"
                name="experienciaProfissional"
                onChange={handleChange}
                id="experienciaProfissional"
                placeholder="Experiência Profissional"
              />
              <div className="form-underline"></div>
            </div>

            <div className="form-input-field">
              <input
                required
                type="text"
                name="pretensaoSalarial"
                onChange={handleChange}
                id="pretensaoSalarial"
                placeholder="Pretensão Salarial"
              />
              <div className="form-underline"></div>
            </div>

            <input type="submit" value="Enviar" onClick={() => pedidoPost()} />
          </form>

          <div className="form-footer">
            <a href="/login2">Já possui login?</a>
          </div>
        </main>
      </body>
    </div>
  );
}

export default FormPage;
