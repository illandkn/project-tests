import React, { useState } from "react";

import axios from "axios";

import "../form/form.css"

function Form() {
  const baseUrl = "https://localhost:5000/api/user";

  const [data, setData] = useState([]);

  const [userSelect, setUserSelect] = useState({
    name: "",
    email: "",
    login: "",
    password: "",
    cpf: "",
    birthDate: "",
    gender: "",
    maritalStatus: "",
    scholarity: "",
    course: "",
    professionalExperience: "",
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
    <div className="App">
      <header>
        <div className="main-form">
          <div className="right-form">
            <div className="card-login">
              <h1>FORM</h1>
              <div className="textfield">
                <br></br>
                <input
                  required
                  type="text"
                  name="name"
                  onChange={handleChange}
                  placeholder="Nome"
                />
              </div>
              <div className="textfield">
                <br></br>
                <input
                  required
                  type="text"
                  name="email"
                  onChange={handleChange}
                  placeholder="E-mail"
                />
              </div>
              <div className="textfield2">
                <br></br>
                <input
                  required
                  type="text"
                  name="login"
                  onChange={handleChange}
                  placeholder="Login"
                />
              </div>
              <div className="textfield2">
                <br></br>
                <input
                  required
                  type="password"
                  name="password"
                  onChange={handleChange}
                  placeholder="Senha"
                />
              </div>
              <div className="textfield">
                <br></br>
                <input
                  type="text"
                  name="cpf"
                  onChange={handleChange}
                  placeholder="CPF"
                />
                {/* <IMaskInput required mask="000.000.000-00" name="cpf" placeholder="CPF" /> */}
              </div>
              <div className="textfield">
                <br></br>
                <input
                  type="text"
                  name="birthDate"
                  onChange={handleChange}
                  placeholder="Data de Nascimento"
                />
                {/* <IMaskInput required mask="00/00/0000" name="datanascimento" placeholder="Data de Nascimento" /> */}
              </div>
              <div className="textfield">
                <br></br>
                {/* <input type="text" name="sexo" placeholder="Sexo" /> */}
                <select required name="gender" onChange={handleChange}>
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
              </div>
              <div className="textfield">
                <br></br>
                {/* <input type="text" name="usuario" placeholder="Estado Civil" /> */}
                <select required name="maritalStatus" onChange={handleChange}>
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
              </div>
              <div className="textfield">
                <br></br>
                {/* <input type="text" name="escolaridade" placeholder="Escolaridade" /> */}
                <select required name="scholarity" onChange={handleChange}>
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
              </div>
              <div className="textfield">
                <br></br>
                <input
                  required
                  type="text"
                  name="course"
                  onChange={handleChange}
                  placeholder="Cursos/ Especializações"
                />
              </div>
              <div className="textfield">
                <br></br>
                <input
                  required
                  type="text"
                  name="professionalExperience"
                  onChange={handleChange}
                  placeholder="Experiência Profissional"
                />
              </div>
              <div className="textfield">
                <br></br>
                <input
                  required
                  type="text"
                  name="pretencao"
                  placeholder="Pretenção Salarial"
                />
              </div>
              <button className="btn-enviar" onClick={() => pedidoPost()}>
                Enviar
              </button>
              <p>
                <span className="textfield">
                  <a href="/login">Já possui conta?</a>
                </span>
              </p>
            </div>
          </div>
        </div>
      </header>
    </div>
  );
}

export default Form;
