import React, { useState, useEffect } from "react";
import axios from "axios";
import "../table/table.css";

function UserTable() {
  const baseUrl = "https://localhost:7197/api/user";

  const [data, setData] = useState([]);

  const pedidoGet = async () => {
    await axios
      .get(baseUrl)
      .then((response) => {
        setData(response.data);
      })
      .catch((error) => {
        console.log(error);
      });
  };

  useEffect(() => {
    pedidoGet();
  });

  return (
    <header className="table-body">
      <div className="table-container">
      <h2 className="table-h2">Tabela</h2>
        <table>
          <thead>
            <tr>
              <th>Nome</th>
              <th>E-mail</th>
              <th>CPF</th>
              <th>Estado Civil</th>
              <th>Escolaridade</th>
              <th>Curso</th>
              <th>Pretensão Salarial</th>
            </tr>
          </thead>
          <tbody>
            {data.map((user) => (
              <tr key={user.id}>
                <td>{user.nome}</td>
                <td>{user.email}</td>
                <td>{user.cpf}</td>
                <td>{user.estadoCivil}</td>
                <td>{user.escolaridade}</td>
                <td>{user.curso}</td>
                <td>{user.pretensaoSalarial}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </header>
  );
}

export default UserTable;
