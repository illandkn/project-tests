import React, { Fragment } from "react";
import { Routes, Route } from "react-router-dom";

import Login from "../../pages/login/login";
import UserTable from "../../pages/table/table";
import LoginPage from "../../pages/login2/login2"
import FormPage from "../../pages/form2/form2";

function AppRoutes() {
  return (
    <div>
      <Routes>
        <Fragment>
          <Route exact path="/login" element={<Login />} />
          <Route exact path="/table" element={<UserTable />} />
          <Route exact path="/login2" element={<LoginPage />} />
          <Route exact path="/form2" element={<FormPage />} />
        </Fragment>
      </Routes>
    </div>
  );
}

export default AppRoutes;
