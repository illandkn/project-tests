import React, { useState, useEffect } from "react";
import axios from "axios";

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
    <header>
      <table>
        <thead>
          <tr>
            <th>Nome</th>
            <th>E-mail</th>
            <th>CPF</th>
            <th>Estado Civil</th>
          </tr>
        </thead>
        <tbody>
          {data.map((user) => (
            <tr key={user.id}>
              <td>{user.nome}</td>
              <td>{user.email}</td>
              <td>{user.cpf}</td>
              <td>{user.estadoCivil}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </header>
  );
}

export default UserTable;
