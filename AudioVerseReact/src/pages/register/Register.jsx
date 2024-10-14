import { useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import { useForm } from "react-hook-form";

import { DefaultInput } from "../../components/forms/default-input/DefaultInput";
import { PasswordInput } from "../../components/forms/password-input/PasswordInput";

import logo from "../../assets/logo.svg";
import { api } from "../../lib/axios";
import styles from "./Register.module.css";

export function Register() {
  const { register, handleSubmit, watch, formState: {errors}} = useForm();
  const navigate = useNavigate();

  const password = watch('password');

  function createAccount(data){
    console.log(data);

    api.post("/UserApp/cadastro", {
      username: data.username,
      password: data.password,
      rePassword: data.confirmPassword
    })
    .then(response => {
      if(response.status === 200){
        navigate("/login");
      }
    })
    .catch(error => console.error(error));
  }

  return (
    <div className="page-account">
      <header className="secondary-header">
        <Link to="/">
          <img className="secondary-logo" src={logo} alt="logo AudioVerse" />
        </Link>
      </header>

      <main className="main">
        <div className="secondary-container">
          <p className="paragraph">Mergulhe em audiobooks de obras de domínio público, disponíveis para ouvir a qualquer momento, em qualquer lugar.</p>
          <h1 className={styles.register__title}>Crie sua conta</h1>
        
          <form onSubmit={handleSubmit(createAccount)} className={styles.register__form} autoComplete="on">
            <div className="form-container">
              <div>
                <DefaultInput
                  error={errors?.username && true}
                  content="Nome de usuário"
                  autoComplete="name"
                  {...register('username', {
                    required: { message: 'O nome de usuário é obrigatório!', value: true },
                    minLength: { message: 'O nome de usuário deve ter mais de 3 caracteres', value: 3},
                    maxLength: { message: 'O nome de usuário precisa ter menos de 42 caracteres!', value: 42},
                    pattern: {
                      value: /^[A-Za-z0-9]+$/,
                      message: 'O nome deve conter apenas letras e números, sem espaços e caracteres especiais!'
                    },
                  })}
                />
                {errors?.username?.message && <p className="error-message">{errors?.username?.message}</p>}
              </div>
              <div>
                <PasswordInput
                  error={errors?.password && true}
                  content="Senha"
                  autoComplete="new-password"
                  {...register('password', {
                    required: { message: 'A senha é obrigatória!', value: true },
                    minLength: { message: 'A senha deve ter mais de 8 caracteres', value: 8},
                    maxLength: { message: 'A senha deve ter menos de 32 caracteres', value: 32},
                    pattern: {
                      value: /^[A-Z][A-Za-z\d!@#$%^&*]*$/,
                      message: 'A senha deve começar com uma letra maiúscula, conter números e apenas os caracteres especiais: !@#$%^&*'
                    },
                  })}
                />
                {errors?.password?.message && <p className="error-message">{errors?.password?.message}</p>}
              </div>
              <div>
                <PasswordInput
                  error={errors?.confirmPassword && true}
                  content="Confirme a Senha"
                  autoComplete="new-password"
                  {...register('confirmPassword', {
                    required: { message: 'A confirmação da senha é obrigatória!', value: true },
                    validate: value => value === password || 'As senhas não correspondem!'
                  })}
                />
                {errors?.confirmPassword?.message && <p className="error-message">{errors?.confirmPassword?.message}</p>}
              </div>
            </div>

            <button className={`submit ${styles.register__submit}`} type="submit">
              Criar
            </button>
          </form>
        </div>
      </main>
    </div>
  )
}